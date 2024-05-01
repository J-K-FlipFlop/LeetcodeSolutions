using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class MinSubarraySum
    {
        public static int MinSubLength(int target, int[] nums)
        {
            int i = 0, j = 0, max = nums.Length, total = 0;

            while(i < nums.Length)
            {
                total += nums[i];
                while( total >= target)
                {
                    max = Math.Min(i - j + 1, max);
                    total -= nums[j];
                    ++j;
                }

                ++i;
            }
            if (max == nums.Length)
            {
                return 0;
            }
            return max;
        }
    }
}
