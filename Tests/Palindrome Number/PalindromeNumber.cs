using System;
using System.Linq;
using Xunit;

namespace Tests.Palindrome_Number
{
    public class PalindromeNumber
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(-1, false)]
        [InlineData(123, false)]
        [InlineData(2332, true)]
        [InlineData(2342, false)]
        [InlineData(Int32.MaxValue, false)]
        [InlineData(313, true)]
        [InlineData(1001, true)]
        [InlineData(100021, false)]
        [InlineData(1000110001, true)]
        public void TestIsPalindrome(int x, bool expected)
        {
            var actual = Problems.PalindromeNumber.PalindromeNumber.IsPalindrome(x);
            Assert.Equal(expected, actual);
        }
    }
}
