using System;
using System.Linq;
using Xunit;
using Problems.ReverseInteger;

namespace Tests.ReverseInteger
{
    public class ReverseInteger
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(-19999999, -99999991)]
        [InlineData(19999999, 99999991)]
        [InlineData(1000000003, 0)]
        [InlineData(-1000000003, 0)]
        public void TestReverseInteger(int input, int expected)
        {
            int actual = Solution.Reverse(input);

            Assert.Equal(expected, actual);
        }
    }
}
