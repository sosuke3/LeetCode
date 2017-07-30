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
            if(string.IsNullOrEmpty(p))
            {
                return string.IsNullOrEmpty(s);
            }

            if(p.Length > 1 && '*' == p[1])
            {
                // x*
                return (IsMatch(s, p.Substring(2)) || (!string.IsNullOrEmpty(s) && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p)));
            }
            else
            {
                return !string.IsNullOrEmpty(s) && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p.Substring(1));
            }
        }
    }
}
