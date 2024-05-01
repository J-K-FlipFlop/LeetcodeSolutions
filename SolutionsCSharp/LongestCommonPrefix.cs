using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class LongestCommonPrefix
    {
        public static string FindLongest(string[] strs)
        {
            int shortest = strs[0].Length;
            StringBuilder result = new StringBuilder();

            for(int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length <= shortest)
                {
                    shortest = strs[i].Length;
                }
            }


            for (int i = 0; i < shortest; i++)
            {
                for(int j = 0; j < strs.Length - 1; j++)
                {
                    if(strs[j][i] != strs[j + 1][i])
                    {
                        return result.ToString();
                    }
                }

                result.Append(strs[0][i]);
            }

            return result.ToString();
        }
    }
}
