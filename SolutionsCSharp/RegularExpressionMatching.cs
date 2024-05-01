using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            StringBuilder sb = new StringBuilder(s);
            StringBuilder pb = new StringBuilder(p);

            for(int i = 0; i < pb.Length; i++)
            {
                if (pb[i] == '.')
                {
                    sb[i] = '.';
                }


                if (pb[i] == '*')
                {
                    if (pb[i - 1] == '.')
                    {
                        string sStart = sb.ToString().Substring(0, i - 1);
                        string pStart = pb.ToString().Substring(0, i - 1);

                        if (pStart.Equals(sStart))
                        {
                            return true;
                        }
                    }

                    while(sb[i] == pb[i - 1])
                    {
                        sb.Remove(i, 1);

                        if ( i == sb.Length)
                        {
                            break;
                        }
                    }

                    pb.Remove(i - 1, 1);

                    sb.Remove(i - 1, 1);
                    sb.Insert(i - 1, '*');
                    --i;
                }


            }

            if (pb.Equals(sb))
            {
                return true;
            }

            return false;
        }
    }
}
