using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.RegularExpressionMatching
{
    public static class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return string.IsNullOrEmpty(s);
            }

            if (s == p)
            {
                return true;
            }

            // x*
            if (p.Length > 1 && '*' == p[1])
            {
                // x* matches x, advance to next s and check it
                if (!string.IsNullOrEmpty(s) && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p))
                {
                    return true;
                }
                // x* doesn't match x, skip to next p
                if (IsMatch(s, p.Substring(2)))
                {
                    return true;
                }
            }
            // xy
            else
            {
                // x matchs x, advance both to the next substring
                if (!string.IsNullOrEmpty(s) && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p.Substring(1)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
