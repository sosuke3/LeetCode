using System;
using System.Linq;
using Xunit;

namespace Tests.MyAtoi
{
    public class MyAtoi
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("10", 10)]
        [InlineData("1000000000000", 0)]
        [InlineData("-1", -1)]
        [InlineData("-1000000000000", 0)]
        [InlineData("12340", 12340)]
        [InlineData("01", 1)]
        [InlineData("10 asfd", 10)]
        [InlineData("+ 10 asfd", 0)]
        [InlineData("- 10 asfd", 0)]
        [InlineData("+ 10", 0)]
        [InlineData("+1", 1)]
        [InlineData("+10", 10)]
        [InlineData("+1000000000000", 0)]
        [InlineData("", 0)]
        public void TestMyAtoi(string input, int expected)
        {
            var actual = Problems.StringToInteger.Solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }
    }
}
