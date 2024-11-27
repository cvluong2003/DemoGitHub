using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning;
namespace GUI
{
    class Data
    {
      
           
        public Data()
        {
           
        }
        public int[] Learn(List<SinhVien> lst)
        {
           
            int row=lst.Count();
      
            Accord.Math.Random.Generator.Seed = 0;

            // Declare some observations
            double[][] observations = new double[row][];
            for (int i=0 ;i<lst.Count() ;i++)
            {
                observations[i] = new double[3];
                observations[i][0] =(double) lst[i].nv1;
                observations[i][1] = (double)lst[i].nv2;
                observations[i][2] =(double)lst[i].nv3;
            }

           
            KMeans kmeans = new KMeans(k: 3);

            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(observations);

            // Use the centroids to parition all the data
            int[] labels = clusters.Decide(observations);
            return labels;
        }
      
    }

}
