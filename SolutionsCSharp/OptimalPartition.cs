using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class OptimalPartition
    {
        public static int FindOptimalPartition(string s)
        {
            int i = 0;
            int partitions = 1;
            HashSet<char> chars = new HashSet<char>();

            while (i < s.Length)
            {

                if (chars.Contains(s[i]))
                {
                    chars.Clear();
                    ++partitions;
                    chars.Add(s[i]);
                    ++i;
                }
                else
                {
                    chars.Add(s[i]);
                    ++i;
                }
            }

            return partitions;
        }
    }
}
