using System;
using System.Linq;
using Xunit;

namespace Tests.LengthOfLongestSubstring
{
    public class LengthOfLongestSubstring
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void TestLengthOfLongestSubstring(string input, int expected)
        {
            var actual = Problems.LengthOfLongestSubstring.Solution.LengthOfLongestSubstring(input);
            Assert.Equal(expected, actual);
        }
    }
}
