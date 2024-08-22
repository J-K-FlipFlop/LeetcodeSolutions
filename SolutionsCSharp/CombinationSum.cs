using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class CombinationSum
    {
        public static IList<IList<int>> CombinationSumMethod(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < candidates.Length; i++)
            {
                int cand = candidates[i];
                for (int j = cand; j <= target; j+= cand)
                {
                    int diff = target - j;
                    myDict.Add(diff, cand);
                }
            }

            foreach (KeyValuePair<int, int> pair in myDict)
            {
                Console.WriteLine(pair);
            }

            return result;
        }
    }
}