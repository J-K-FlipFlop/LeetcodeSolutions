using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class Permutations
    {
        public static List<String> SinglePermutations(string s)
        {

            // s = "abcd"

            int n = s.Length;
            int permutations = 1;
            List<String> myList = new List<String>();


            for (int i = 0; i < s.Length; i++)
            {
                permutations = permutations * (n - i);
            }

            for (int i = 0; i < permutations; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    myList.Add(SwapChars(s, i, i + 1));
                }
            }


            Console.WriteLine(permutations);
            return myList;
        }

        private static string SwapChars(string str, int index1, int index2)
        {
            char[] myCharArray = str.ToCharArray();
            myCharArray[index1] = str[index2];
            myCharArray[index2] = str[index1];

            return new string(myCharArray);
        }
    }
}
