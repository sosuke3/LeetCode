using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.PalindromeNumber
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x, int expectedCount = 0)
        {
            if(x < 0)
            {
                return false;
            }
            if (x == 0)
            {
                return true;
            }

            int rightDigit = x % 10;
            int leftDigit = x;
            int count = 0;
            while(leftDigit > 9)
            {
                leftDigit = leftDigit / 10;
                count++;
            }
            if(expectedCount > count)
            {
                count = expectedCount;
                leftDigit = 0;
            }

            if(rightDigit == leftDigit)
            {
                if(count == 0)
                {
                    return true;
                }

                int left = (leftDigit * (int)Math.Pow(10, count));

                int next = (x - left - rightDigit) / 10;

                return IsPalindrome(next, count - 2);
            }

            return false;
        }
    }
}
