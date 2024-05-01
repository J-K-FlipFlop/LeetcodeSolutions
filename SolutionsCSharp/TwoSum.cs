using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class TwoSum
    {
        Dictionary<int, int> myDictionary = new Dictionary<int,int>();

        public static int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (myDictionary.ContainsKey(nums[i]))
                {
                    int[] result = { myDictionary[nums[i]], i };
                    return result;
                }
                myDictionary[target - nums[i]] = i;
            }

            int[] resultFail = { 0, 0 };
            return resultFail;
        }
    }
}
