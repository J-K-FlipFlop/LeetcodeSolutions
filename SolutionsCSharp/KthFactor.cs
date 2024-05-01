using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class KthFactor
    {
        public static int FindKthFactor(int n, int k)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }

            }

            if (list.Count < k)
            {
                return -1;
            }

            return list[k - 1];
        }

        public static int FindKthFactorFaster(int n, int k)
        {
            List<int> small = new List<int>();
            List<int> big = new List<int>();
            
            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i == n / i)
                    {
                        small.Add(i);
                    }
                    else
                    {
                        small.Add(i);
                        big.Insert(0, n / i);
                    }

                }
            }

            small.AddRange(big);

            if (k > small.Count) { return -1; }

            return small[k];

        }
    }
}
