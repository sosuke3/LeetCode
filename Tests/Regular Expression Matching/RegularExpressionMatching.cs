using System;
using System.Linq;
using Xunit;

namespace Tests.Regular_Expression_Matching
{
    public class RegularExpressionMatching
    {
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "aa", true)]
        [InlineData("aaa", "aa", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("aa", ".*", true)]
        [InlineData("ab", ".*", true)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("", "", true)]
        [InlineData("a", ".", true)]
        [InlineData("abb", "ab.", true)]
        [InlineData("abb", "ab.*", true)]
        [InlineData("abbbc", "ab.*", true)]
        [InlineData("abcd", "d*", false)]
        [InlineData("abbc", "ab.", false)]
        [InlineData("ab", ".*c", false)]
        [InlineData("abbaa", "ab.*a", true)]
        [InlineData("abbaac", "ab.*a", false)]
        [InlineData("abbaac", "ab.*a.*", true)]
        [InlineData("abbaac", "ab.*ac", true)]
        [InlineData("abbaacc", "ab.*ac", false)]
        public void TestIsMatch(string s, string p, bool expected)
        {
            var actual = Problems.RegularExpressionMatching.RegularExpressionMatching.IsMatch(s, p);
            Assert.Equal(expected, actual);
        }
    }
}
