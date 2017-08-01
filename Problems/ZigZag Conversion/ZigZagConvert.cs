using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ZigZagConvert
{
    public static class Solution
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 0)
                return "";
            if (numRows == 1)
                return s;

            int currentRow = 0;

            string[] strings = new string[numRows];

            int change = 1;

            foreach(var c in s)
            {
                strings[currentRow] += c;

                currentRow += change;

                if (currentRow >= numRows)
                {
                    change = -1;
                    currentRow = numRows - 2;
                }
                if(currentRow < 0)
                {
                    currentRow = 1;
                    change = 1;
                }
            }

            string ret = "";
            foreach(var x in strings)
            {
                ret += x;
            }
            return ret;
        }
    }
}
