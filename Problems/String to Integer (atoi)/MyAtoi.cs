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
            int i = 0;

            if(s[0] == '-' || s[0] == '+')
            {
                sign = (s[0] == '-') ? -1 : 1;
                i++;
            }

            while(i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                ret = ret * 10 + (s[i] - '0');
                i++;

                if (ret * sign > Int32.MaxValue)
                {
                    return Int32.MaxValue;
                }
                if (ret * sign < Int32.MinValue)
                {
                    return Int32.MinValue;
                }
            }

            return (int)ret * sign;
        }
    }
}
