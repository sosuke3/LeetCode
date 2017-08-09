using System;
using System.Linq;
using Xunit;
using Problems.AddTwoNumbers;
using Problems;

namespace Tests.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        [Theory]
        [InlineData(new int[] { 5 }, new int[] { 5 }, new int[] { 0, 1 })]
        [InlineData(new int[] { 2,4,3 }, new int[] { 5,6,4 }, new int[] { 7, 0, 8 })]
        public void TestAddTwoNumbers(int [] first, int [] second, int [] expected)
        {
            ListNode l1 = ListNode.BuildFromArray(first);
            ListNode l2 = ListNode.BuildFromArray(second);

            var actual = Solution.AddTwoNumbers(l1, l2).ToArray();

            Assert.Equal(expected, actual);
        }
    }
}
