using System;
using System.Linq;
using Xunit;
using Problems.IntegerToRoman;

namespace Tests.IntegerToRoman
{
    public class IntegerToRoman
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(40, "XL")]
        [InlineData(70, "LXX")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        [InlineData(1200, "MCC")]
        public void TestIntToRoman(int num, string expected)
        {
            var actual = Solution.IntToRoman(num);

            Assert.Equal(expected, actual);
        }
    }
}
