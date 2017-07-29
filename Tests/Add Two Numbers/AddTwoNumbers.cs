using System;
using System.Linq;
using Xunit;
using Problems.AddTwoNumbers;

namespace Tests.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        [Theory]
        [InlineData(new int[] { 5 }, new int[] { 5 }, new int[] { 0, 1 })]
        [InlineData(new int[] { 2,4,3 }, new int[] { 5,6,4 }, new int[] { 7, 0, 8 })]
        public void TestAddTwoNumbers(int [] first, int [] second, int [] expected)
        {
            Solution.ListNode l1 = Solution.ListNode.BuildFromArray(first);
            Solution.ListNode l2 = Solution.ListNode.BuildFromArray(second);

            var actual = Solution.AddTwoNumbers(l1, l2).ToArray();

            Assert.Equal(expected, actual);
        }
    }
}
