using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CodeWarsSolutions
{
    internal class FindMeanSquare
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double total = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                total += (firstArray[i] - secondArray[i]) * (firstArray[i] - secondArray[i]);
            }
            double result = total/firstArray.Length;
            return result;
        }
    }
}
