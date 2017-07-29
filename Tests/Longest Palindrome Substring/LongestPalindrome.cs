using System;
using System.Linq;
using Xunit;

namespace Tests.LongestPalindrome
{
    public class LongestPalindrome
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("abababbabababaaaaaaaaaaaaaa", "aaaaaaaaaaaaaa")]
        [InlineData("aaabaaaa", "aaabaaa")]
        [InlineData("a", "a")]
        [InlineData("abcda", "a")]
        public void TestLongestPalindrome(string input, string expected)
        {
            var actual = Problems.LongestPalindrome.Solution.LongestPalindrome(input);
            Assert.Equal(expected, actual);
        }
    }
}
