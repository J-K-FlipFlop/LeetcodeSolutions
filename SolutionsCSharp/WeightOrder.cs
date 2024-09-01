using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class WeightOrder
    {
        public static string weightSort(string str)
        {
            string[] weights = str.Split(' ');
            for (int i = 0; i < weights.Length; i++)
            {
                string weight = weights[i];
                Console.WriteLine(weight);
                int total = 0;
                for (int j = 0; j < weight.Length; j++)
                {
                    Console.WriteLine(weight[j]);
                    total += weight[j] - 48;
                }
                Console.WriteLine(total);
            }
            return str;
        }
    }
}