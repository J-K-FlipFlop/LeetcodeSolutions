using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            string xAsString = x.ToString();

            if (xAsString.Length == 1)
            {
                return true;
            }

            int length = xAsString.Length / 2;

            for (int i = 0; i < length; i++)
            {
                char myChar = xAsString[i];
                char myChar2 = xAsString[xAsString.Length - 1 - i];

                if (xAsString[i] != xAsString[xAsString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
