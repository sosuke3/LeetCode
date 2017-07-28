using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LengthOfLongestSubstring
{
    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var longestString = "";
            var currentString = "";

            for(int i=0; i<s.Length; i++)
            {
                int index = currentString.IndexOf(s[i]);

                if(index >= 0)
                {
                    if (index + 1 > currentString.Length)
                    {
                        currentString = "";
                    }
                    else
                    {
                        currentString = currentString.Substring(index + 1);
                    }
                }

                currentString += s[i];

                if(currentString.Length > longestString.Length)
                {
                    longestString = currentString;
                }
            }

            return longestString.Length;
        }

        public static string Run()
        {
            string input = "vvvv";

            return LengthOfLongestSubstring(input).ToString();
        }
    }
}
