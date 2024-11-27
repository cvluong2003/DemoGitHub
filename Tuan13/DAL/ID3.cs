using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ID3
    {
        public void id3Funtion()
        {
            int[][] inputs =
{
    new int[] { 0, 0 },
    new int[] { 0, 1 },
    new int[] { 1, 0 },
    new int[] { 1, 1 },
};

            int[] outputs = // xor between inputs[0] and inputs[1]
{
    0, 1, 1, 0
};

            // Create an ID3 learning algorithm
            ID3Learning teacher = new ID3Learning();

            // Learn a decision tree for the XOR problem

            var tree = teacher.Learn(inputs, outputs);

            // Compute the error in the learning
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            // The tree can now be queried for new examples:
            int[] predicted = tree.Decide(inputs); // should be { 0, 1, 1, 0 }
        }
    }
    // In this example, we will learn a decision tree directly from integer
    // matrices that define the inputs and outputs of our learning problem.


}
