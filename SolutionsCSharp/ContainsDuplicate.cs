using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class ContainsDuplicate
    {
        public static bool ContainsNearbyDupe(int[] nums, int k)
        {
            int i = 0, j = 0;
            HashSet<int> visited = new HashSet<int>();

            while(i < nums.Length)
            {
                int x = nums[i];
   
                if (i - j > k)
                {
                    visited.Remove(nums[j]);
                    j++;
                }

                if (visited.Contains(x))
                {
                    return true;
                }

                visited.Add(x);
                i++;
            }

            return false;
        }
    }
}
