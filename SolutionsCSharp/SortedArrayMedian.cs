using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class SortedArrayMedian
    {
        public static double FindMedian(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            int m = nums1.Length, n = nums2.Length;
            int[] sortedArr = new int[m+n];
            int len = sortedArr.Length;
            double median = 0;

            while ((i <= m || j <= n) && i + j < sortedArr.Length)
            {
                if (i!= m && (j == n || nums1[i] < nums2[j]))
                {
                    sortedArr[i+j] = nums1[i];
                    ++i;
                }
                else
                {
                    sortedArr[i + j] = nums2[j];
                    ++j;
                }
            }


            if(len % 2 == 0)
            {
                median = Convert.ToDouble(sortedArr[len/2] + sortedArr[(len/2) - 1])/2;
            }
            else
            {
                median = Convert.ToDouble(sortedArr[(len/2)]);
            }

            Console.WriteLine(median);
            return median;
        }

        //int[] nums1 = { 1, 2, 3, 4, 9 };
        //int[] nums2 = { 5, 6, 7, 8, 11 };
    }
}
