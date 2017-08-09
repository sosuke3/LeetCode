using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.IntegerToRoman
{
    public static class Solution
    {
        public static string IntToRoman(int num)
        {
            if(num <= 0)
            {
                return "";
            }

            var sb = new StringBuilder();

            int thousandDigit = (num / 1000) % 10;
            int hundredDigit = (num / 100) % 10;
            int tenDigit = (num / 10) % 10;
            int firstDigit = num % 10;

            BuildDigit(thousandDigit, sb, "M", "V̅", "X̅");
            BuildDigit(hundredDigit, sb, "C", "D", "M");
            BuildDigit(tenDigit, sb, "X", "L", "C");
            BuildDigit(firstDigit, sb, "I", "V", "X");

            return sb.ToString();
        }

        public static void BuildDigit(int digit, StringBuilder sb, string One, string Five, string Ten)
        {
            // yes there is a better way to do this with hardcoded arrays
            // I wanted to do this.

            if(digit >= 5 && digit < 9)
            {
                sb.Append(Five);
            }
            if(digit == 4 || digit == 9)
            {
                sb.Append(One);
            }
            if(digit == 1 || digit == 6)
            {
                sb.Append(One);
            }
            if(digit == 2 || digit == 7)
            {
                sb.Append(One[0], 2);
            }
            if (digit == 3 || digit == 8)
            {
                sb.Append(One[0], 3);
            }
            if(digit == 4)
            {
                sb.Append(Five);
            }
            if(digit == 9)
            {
                sb.Append(Ten);
            }
        }
    }
}
