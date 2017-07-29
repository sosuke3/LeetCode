using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringToInteger
{
    public static class Solution
    {
        public static int MyAtoi(string str)
        {
            var s = str.Trim();
            if(s.Length == 0)
            {
                return 0;
            }

            long ret = 0;
            int sign = 1;

            if(s[0] == '-')
            {
                sign = -1;
            }

            int start = 0;
            if(s[0] == '-' || s[0] == '+')
            {
                start = 1;
            }

            try
            {
                for (int i = start; i < s.Length; i++)
                {
                    ret = ret * 10 + CharToInt(s[i]);
                }
            }
            catch
            {
                return (int)ret * sign;
            }

            if(ret > Int32.MaxValue)
            {
                return 0;
            }
            if(ret < Int32.MinValue)
            {
                return 0;
            }

            return (int)ret * sign;
        }

        public static int CharToInt(char c)
        {
            switch(c)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    return c - 48;
            }

            throw new InvalidOperationException();
        }
    }
}
