using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            List<int> que = new List<int>();
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    que.Insert(0, s[i]);
                    ++counter;
                }

                if (s[i] == ')')
                {
                    if (que[0] != '(' || counter == 0)
                    {
                        return false;
                    }
                    else
                    {
                        que.RemoveAt(0);
                        --counter;
                    }
                }

                if (s[i] == '}')
                {
                    if (que[0] != '{' || counter == 0)
                    {
                        return false;
                    }
                    else
                    {
                        que.RemoveAt(0);
                    }
                }

                if (s[i] == ']')
                {
                    if (que[0] != '[' || counter == 0)
                    {
                        return false;
                    }
                    else
                    {
                        que.RemoveAt(0);
                    }
                }
            }

            if (que.Count != 0)
            {
                return false;
            }

            return true;

        }
    }
}
