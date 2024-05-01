using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class RepeatedSubPattern
    {
        public static bool IsRepeatingSub(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for(int i = 1; i < s.Length/2; i++)
            {
                if(s.Length % i == 0)
                {
                    string substring = s.Substring(0,s.Length/i);
                    StringBuilder subString = new StringBuilder(substring);
                    for(int j = 0; j < s.Length/i; j++)
                    {
                        sb = sb.Insert(0, subString);
                    }

                    if (sb.ToString().Equals(s))
                    {
                        return true;
                    }
                }

            }
                return false;
        }
    }
}
