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
namespace DAL
{
   public class ID3_D2
    {
        public ID3_D2()
        {

        }
        public void ID3_D2_Function()
        {


            // Create the dataset (Mitchell's Tennis Example)
            DataTable data = new DataTable("Mitchell's Tennis Example");

            data.Columns.Add("Day");
            data.Columns.Add("Outlook");
            data.Columns.Add("Temperature");
            data.Columns.Add("Humidity");
            data.Columns.Add("Wind");
            data.Columns.Add("PlayTennis");

            data.Rows.Add("D1", "Sunny", "Hot", "High", "Weak", "No");
            data.Rows.Add("D2", "Sunny", "Hot", "High", "Strong", "No");
            data.Rows.Add("D3", "Overcast", "Hot", "High", "Weak", "Yes");
            data.Rows.Add("D4", "Rain", "Mild", "High", "Weak", "Yes");
            data.Rows.Add("D5", "Rain", "Cool", "Normal", "Weak", "Yes");
            data.Rows.Add("D6", "Rain", "Cool", "Normal", "Strong", "No");
            data.Rows.Add("D7", "Overcast", "Cool", "Normal", "Strong", "Yes");
            data.Rows.Add("D8", "Sunny", "Mild", "High", "Weak", "No");
            data.Rows.Add("D9", "Sunny", "Cool", "Normal", "Weak", "Yes");
            data.Rows.Add("D10", "Rain", "Mild", "Normal", "Weak", "Yes");
            data.Rows.Add("D11", "Sunny", "Mild", "Normal", "Strong", "Yes");
            data.Rows.Add("D12", "Overcast", "Mild", "High", "Strong", "Yes");
            data.Rows.Add("D13", "Overcast", "Hot", "Normal", "Weak", "Yes");
            data.Rows.Add("D14", "Rain", "Mild", "High", "Strong", "No");

            // Create a new codification codebook to convert strings into integer symbols
            var codebook = new Codification(data);

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
                inputs[i][0] = (int)symbols.Rows[i]["Outlook"];
                inputs[i][1] = (int)symbols.Rows[i]["Temperature"];
                inputs[i][2] = (int)symbols.Rows[i]["Humidity"];
                inputs[i][3] = (int)symbols.Rows[i]["Wind"];

                // Extract the output (PlayTennis)
                outputs[i] = (int)symbols.Rows[i]["PlayTennis"];
            }

            // Create a teacher ID3 algorithm
            var id3learning = new ID3Learning()
            {
                new DecisionVariable("Outlook", 3), // 3 possible values (Sunny, Overcast, Rain)
                new DecisionVariable("Temperature", 3), // 3 possible values (Hot, Mild, Cool)
                new DecisionVariable("Humidity", 2), // 2 possible values (High, Normal)
                new DecisionVariable("Wind", 2) // 2 possible values (Weak, Strong)
            };

            // Learn the training instances
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));


            // Make a prediction for a new example
            int[] query = codebook.Transform(new[,]
            {
                { "Outlook", "Sunny" },
                { "Temperature", "Hot" },
                { "Humidity", "High" },
                { "Wind", "Strong" }
            });

            // Predict the result
            int predicted = tree.Decide(query);

            // Convert the result back to strings
            string answer = codebook.Revert("PlayTennis", predicted);
           
        }
    }
}


