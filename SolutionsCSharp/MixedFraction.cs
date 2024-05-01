using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class MixedFraction
    {
        public static string MixedFractionMethod(string s) //  -42/9
        {
            string[] nums = s.Split('/');
            int numerator = Int32.Parse(nums[0]);
            int denominator = Int32.Parse(nums[1]);

            int num1 = numerator/ denominator;
            int num2 = System.Math.Abs(numerator % denominator);

            int GreatestCommonDenominator = GCD(numerator, denominator);

            num2 = num2 / GreatestCommonDenominator;
            int denominatorSimp = System.Math.Abs(denominator / GreatestCommonDenominator);

            string result = $"{num1} {num2}/{denominatorSimp}";

            if (numerator == 0 || num2 == 0)
            {
                result = $"{num1}";
            }

            if (num1 == 0 && numerator > 0)
            {
                result = $"{num2}/{denominatorSimp}";
            }

            if (num1 == 0 && numerator < 0)
            {
                result = $"-{num2}/{denominatorSimp}";
            }

            if (num1 == 0 && numerator < 0 && denominator < 0)
            {
                result = $"{num2}/{denominatorSimp}";
            }

            if (num1 == 0 && numerator > 0 && denominator < 0)
            {
                result = $"-{num2}/{denominatorSimp}";
            }

            Console.WriteLine(result);

            return result;
        }

        private static int GCD(int a, int b)
        {

            a = System.Math.Abs(a);
            b = System.Math.Abs(b);

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
