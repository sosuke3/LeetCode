using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LongestPalindrome
{
    public static class Solution
    {
        // TODO: make this better

        public static string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }

            string longest = "";

            for(int i = 0; i < s.Length; i++)
            {
                if (longest.Length > s.Length - i)
                {
                    // remainder is shorter than the longest palindrome found
                    break;
                }

                var current = s[i];

                var index = s.LastIndexOf(current);

                if(index < 0)
                {
                    continue;
                }

                string palindrome = string.Empty;

                for (int j = index; j >= i; j--)
                {
                    palindrome = CheckForPalindrome(s, i, j);

                    if (!string.IsNullOrEmpty(palindrome))
                    {
                        break;
                    }
                }
                
                if(palindrome.Length > longest.Length)
                {
                    longest = palindrome;
                }
            }

            return longest;
        }

        private static string CheckForPalindrome(string s, int startindex, int endindex)
        {
            for (int j = startindex, k = endindex; j < k; j++, k--)
            {
                if (s[j] != s[k])
                {
                    return string.Empty;
                }
            }

            return s.Substring(startindex, endindex - startindex + 1);
        }
    }
}
