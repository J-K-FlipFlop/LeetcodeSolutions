using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class DNASubsequence
    {
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> set = new HashSet<string>();
            IList<string> result = new List<string>();
            int i = 0;
            StringBuilder sb = new StringBuilder("0123456789");

            while(i + 9< s.Length)
            {
                string subStr = s.Substring(i, 10);

                if (set.Contains(subStr))
                {
                    result.Remove(subStr);
                    result.Add(subStr);
                }
                else
                {
                    set.Add(subStr);
                }

                ++i;
            }

            return result;
        }
    }
}
