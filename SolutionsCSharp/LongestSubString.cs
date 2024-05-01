using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class LongestSubString
    {
        public static int FindLongestSub(string s)
        {
            //aaabcaa
            int pointer1 = 0, pointer2 = 0, max = 0;
            HashSet<int> set = new HashSet<int>();

            while(pointer2 < s.Length)
            {
                char c = s[pointer2];

                while (set.Contains(c))
                {
                    set.Remove(s[pointer1]);
                    ++pointer1;
                }

                set.Add(c);
                max = Math.Max(max, pointer2 - pointer1 + 1);
                ++pointer2;

            }
            return max;
        }
    }
}
