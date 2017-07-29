using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ReverseInteger
{
    public static class Solution
    {
        public static int Reverse(int x)
        {
            int ret = 0;

            while (x != 0)
            {
                try
                {
                    ret = checked((ret * 10) + (x % 10));
                    x = x / 10;
                }
                catch
                {
                    ret = 0;
                    break;
                }
            }

            return ret;
        }

        public static string Run()
        {
            int x = -1999999999;

            return Reverse(x).ToString();
        }
    }
}
