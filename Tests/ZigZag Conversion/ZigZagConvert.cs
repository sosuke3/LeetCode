using System;
using System.Linq;
using Xunit;

namespace Tests.ZigZagConvert
{
    public class ZigZagConvert
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 0, "")]
        [InlineData("PAYPALISHIRING", 1, "PAYPALISHIRING")]
        [InlineData("PAYPALISHIRING", 2, "PYAIHRNAPLSIIG")]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void TestConvert(string input, int rows, string expected)
        {
            var actual = Problems.ZigZagConvert.Solution.Convert(input, rows);
            Assert.Equal(expected, actual);
        }
    }
}
