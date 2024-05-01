using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class RemoveDuplicates
    {
        public static int RemoveDupes(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[i] = 0;
                }
            }
            nums = nums.Where(x => x != 0).ToArray();

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);

            int k = nums.Length;

            return k;
        }
    }
}
