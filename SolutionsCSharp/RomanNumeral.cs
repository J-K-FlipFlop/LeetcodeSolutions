using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class RomanNumeral
    {
        public static int RomanToInt(string s)
        {
            int value = 0;
            int total = 0;
            int j = 0;

            StringBuilder sb = new StringBuilder(s + '*', s.Length + 1);

            for(int i = 0; i < s.Length; i++)
            {
                j = 0;
                if (sb[i] == 'M') { value = 1000; };

                if (sb[i] == 'D') { value = 500; };

                if (sb[i] == 'C')
                {
                    if (sb[i + 1] == 'D') { value = 400; ++j; }
                    else if (sb[i+1] == 'M') { value = 900; ++j; }
                    else { value = 100; }
                }

                if (sb[i] == 'L') { value = 50; }

                if (sb[i] == 'X')
                {
                    if (sb[i+1] == 'L') { value = 40; ++j; }
                    else if (sb[i+1] == 'C') { value = 90; ++j; }
                    else { value = 10; }
                }

                if (sb[i] == 'V') { value = 5; }

                if (sb[i] == 'I')
                {
                    if (sb[i + 1] == 'V') { value = 4; ++j; }
                    else if (sb[i + 1] == 'X') { value = 9; ++j; }
                    else { value = 1; }
                }

                total += value;
                i += j;
            }

            return total;
        }

        public static string IntToRoman(int num)
        {

            int digits = num.ToString().Length;
            int digit = 0;

            StringBuilder result = new StringBuilder();

            for (int i = digits - 1; i >= 0; i--)
            {
                int power = Convert.ToInt32(Math.Pow(10, i));

                digit = num / power;
                num -= digit * power;

                if (power == 1000)
                {
                    for (int j = 0; j < digit; j++)
                    {
                        result.Append('M');
                    }
                }

                if (power == 100)
                {
                    if(digit == 4) { result.Append("CD"); }
                    else if(digit == 9) { result.Append("CM"); }
                    else if(digit < 4)
                    {
                        for (int j = 0; j < digit; j++)
                        {
                            result.Append('C');
                        }
                    }
                    else if(digit >= 5)
                    {
                        result.Append('D');
                        for (int j = 5; j < digit; j++)
                        {
                            result.Append('C');
                        }
                    }
                }

                if (power == 10)
                {
                    if (digit == 4) { result.Append("XL"); }
                    else if (digit == 9) { result.Append("XC"); }
                    else if (digit < 4)
                    {
                        for (int j = 0; j < digit; j++)
                        {
                            result.Append('X');
                        }
                    }
                    else if (digit >= 5)
                    {
                        result.Append('L');
                        for (int j = 5; j < digit; j++)
                        {
                            result.Append('X');
                        }
                    }

                }

                if (power == 1)
                {
                    if (digit == 4) { result.Append("IV"); }
                    else if (digit == 9) { result.Append("IX"); }
                    else if (digit < 4)
                    {
                        for (int j = 0; j < digit; j++)
                        {
                            result.Append('I');
                        }
                    }
                    else if (digit >= 5)
                    {
                        result.Append('V');
                        for (int j = 5; j < digit; j++)
                        {
                            result.Append('I');
                        }
                    }
                }

            }
                return result.ToString();
        }
    }
}
