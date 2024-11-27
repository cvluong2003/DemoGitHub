using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning;
using DTO2;
namespace DAL
{
    public class ID3_D3
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        DecisionTree tree;
        Codification codebook;
        public ID3_D3()
        {

        }
        public DataTable ConvertToDataTable(List<Sheet1_> lst)
        {
            DataTable dataTable = new DataTable();


            // Tạo cột cho DataTable từ các thuộc tính của lớp Person
            dataTable.Columns.Add("dc_nnlt", typeof(string));
            dataTable.Columns.Add("dc_th_nnlt", typeof(string));
            dataTable.Columns.Add("dc_lthdt", typeof(string));
            dataTable.Columns.Add("dc_th_lthdt", typeof(string));
            dataTable.Columns.Add("dc_ctdl_gt", typeof(string));
            dataTable.Columns.Add("dc_th_ctdlgt", typeof(string));
            dataTable.Columns.Add("dc_csdl", typeof(string));
            dataTable.Columns.Add("dc_th_csdl", typeof(string));

            dataTable.Columns.Add("dc_toancc", typeof(string));
            // Duyệt qua danh sách các đối tượng và thêm vào DataTable
            foreach (var person in lst)
            {
                dataTable.Rows.Add(person.dc_nnlt, person.dc_th_nnlt, person.dc_lthdt, person.dc_th_lthdt, person.dc_ctdl_gt, person.dc_th_ctdlgt, person.dc_csdl, person.dc_th_csdl, person.dc_toancc);

            }
            return dataTable;
        }
        public string QD(string[] data)
        {
            int[] query = codebook.Transform(new[,]
            {
                { "dc_nnlt", data[0] },
                { "dc_th_nnlt", data[1]  },
                { "dc_lthdt", data[2]  },
                { "dc_th_lthdt", data[3]  },
                  { "dc_ctdl_gt",data[4]  },
                { "dc_th_ctdlgt", data[5] },
                { "dc_csdl",data[6] },
                { "dc_th_csdl", data[7] },
                   { "dc_toancc", data[8]  }
            });

            // Predict the result
            int predicted = tree.Decide(query);

            // Convert the result back to strings
            string answer = codebook.Revert("chuyennganh", predicted);
            return answer;
        }
        public double ID3_D2_Function()
        {

            var all = context.Sheet1_s.ToList();
            // Create the dataset (Mitchell's Tennis Example)
            DataTable data =ConvertToDataTable(all);



            // Create a new codification codebook to convert strings into integer symbols
            codebook = new Codification(data);

            // Translate our training data into integer symbols using our codebook
            DataTable symbols = codebook.Apply(data);

            // Initialize arrays to hold the input and output data
            int numRows = symbols.Rows.Count;
            int numCols = symbols.Columns.Count - 2; // Exclude 'PlayTennis' column

            // Initialize the input and output arrays
            int[][] inputs = new int[numRows][];
            int[] outputs = new int[numRows];

            // Manually extract data from the DataTable and convert to integers
            for (int i = 0; i < numRows; i++)
            {
                inputs[i] = new int[numCols];
      
                // For each input column (Outlook, Temperature, Humidity, Wind)
                inputs[i][0] = (int)symbols.Rows[i]["dc_nnlt"];
                inputs[i][1] = (int)symbols.Rows[i]["dc_th_nnlt"];
                inputs[i][2] = (int)symbols.Rows[i]["dc_lthdt"];
                inputs[i][3] = (int)symbols.Rows[i]["dc_th_lthdt"];
                inputs[i][4] = (int)symbols.Rows[i]["dc_ctdl_gt"];
                inputs[i][5] = (int)symbols.Rows[i]["dc_th_ctdlgt"];
                inputs[i][6] = (int)symbols.Rows[i]["dc_csdl"];
                inputs[i][7] = (int)symbols.Rows[i]["dc_th_csdl"];
                inputs[i][8] = (int)symbols.Rows[i]["dc_toancc"];
                // Extract the output (PlayTennis)
                outputs[i] = (int)symbols.Rows[i]["chuyennganh"];
            }

            // Create a teacher ID3 algorithm
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("dc_nnlt", 5), // 3 possible values (Sunny, Overcast, Rain)
                new DecisionVariable("dc_th_nnlt", 5), // 3 possible values (Hot, Mild, Cool)
                new DecisionVariable("dc_lthdt", 5), // 2 possible values (High, Normal)
                new DecisionVariable("dc_th_lthdt", 5),// 2 possible values (Weak, Strong)
                new DecisionVariable("dc_ctdl_gt", 5), // 3 possible values (Sunny, Overcast, Rain)
                new DecisionVariable("dc_th_ctdlgt", 5), // 3 possible values (Hot, Mild, Cool)
                new DecisionVariable("dc_csdl", 5), // 2 possible values (High, Normal)
                new DecisionVariable("dc_th_csdl", 5) // 2 possible values (Weak, Strong)
            };

            // Learn the training instances
            tree = id3learning.Learn(inputs, outputs);

            // Compute the training error
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));


            // Make a prediction for a new example
            return error;

        }
    }
}
