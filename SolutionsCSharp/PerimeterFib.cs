using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class PerimiterFib
    {
        public int FindPerim(int n)
        {
            int result = 0;

            if (n == 1 | n == 2)
            {
                result = n;
                return result;
            }

            List<int> lenList = new List<int>();
            int size = 1;
            lenList.Add(size);
            lenList.Add(size);

            for (int i = 0; i < n - 2; i++)
            {
                size = lenList[i] + lenList[i + 1];
                lenList.Add(size);
            }

            for (int i = 0; i < n; i++)
            {
                result += lenList[i] * 4;
            }

            return result;
        }
    }
}