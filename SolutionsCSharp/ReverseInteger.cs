using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class ReverseInteger
    {
        //x = 123
        public static int Reverse(int x)
        {
            int max = 2147483647;
            int min = -2147483648;
            int reverse = 0;

            while (x != 0)
            {
                if (reverse > max/10 || reverse < min/10)
                {
                    return 0;
                }
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }

            return reverse;
        }
    }
}
