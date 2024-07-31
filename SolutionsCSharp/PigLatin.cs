using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class PigLatin
    {
        public static string PigIt(string str)
        {
            string[] subStrs = str.Split(' ');
            StringBuilder sbResult = new StringBuilder();

            for (int i = 0; i < subStrs.Length; i++)
            {
                if (!Char.IsPunctuation(subStrs[i], 0))
                {
                    StringBuilder sb = new StringBuilder(subStrs[i]);

                    char firstChar = sb[0];
                    sb.Remove(0, 1);
                    sb.Append(firstChar);
                    sb.Append("ay");

                    subStrs[i] = sb.ToString();
                }
            }

            for(int i = 0; i < subStrs.Length; i++)
            {
                sbResult.Append(" ");
                sbResult.Append(subStrs[i]);
            }

            sbResult.Remove(0, 1);
            string result = sbResult.ToString();

            return result;
        }
    }
}