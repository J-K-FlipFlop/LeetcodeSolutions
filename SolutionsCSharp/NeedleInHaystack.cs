using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class NeedleInHaystack
    {
        public static int FindNeedle(string haystack, string needle)
        {
            int needleLen = needle.Length;

            for(int i = 0; i < needleLen; i++)
            {
                if(needle == haystack.Substring(i, needleLen)){
                    return i;
                }
            }

            return -1;
        }
    }
}
