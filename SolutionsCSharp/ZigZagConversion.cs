using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            int numCollsPerBlock = numRows - 1;
            int charsPerBlock = 2 * numRows - 2;
            int numBlocks = s.Length / charsPerBlock;

            if (s.Length % charsPerBlock != 0)
            {
                ++numBlocks;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numBlocks; ++i)
            {
                result.Append(s[i * charsPerBlock]);
            }

            for (int j = 1; j < numRows - 1; j++)
            {
                for (int i = 0; i < numBlocks; i++)
                {
                    if ((i * charsPerBlock) + j < s.Length)
                    {
                        result.Append(s[(i * charsPerBlock) + j]);
                    }

                    if ((charsPerBlock - j) + i * charsPerBlock < s.Length)
                    {
                        result.Append(s[(charsPerBlock - j) + i * charsPerBlock]);
                    }
                }
            }

            for (int i = 0; i < numBlocks; ++i)
            {
                if ((i * charsPerBlock) + (numRows - 1) < s.Length)
                {
                    result.Append(s[(i * charsPerBlock) + (numRows - 1)]);
                }
            }

            return result.ToString();
        }
    }
}
