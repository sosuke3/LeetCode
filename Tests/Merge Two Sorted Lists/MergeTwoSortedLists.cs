using System;
using System.Linq;
using Xunit;
using Problems.MergeTwoSortedLists;
using Problems;

namespace Tests.MergeTwoSortedLists
{
    public class MergeTwoSortedLists
    {
        [Theory]
        [InlineData(new int[] { 5 }, new int[] { 5 }, new int[] { 5, 5 })]
        [InlineData(new int[] { 1,2,3 }, new int[] { 4,5,6 }, new int[] { 1,2,3,4,5,6 })]
        [InlineData(new int[] { 1, 2, 5 }, new int[] { 3, 4, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        public void TestMergeTwoLists(int [] first, int [] second, int [] expected)
        {
            ListNode l1 = ListNode.BuildFromArray(first);
            ListNode l2 = ListNode.BuildFromArray(second);

            var actual = Solution.MergeTwoLists(l1, l2).ToArray();

            Assert.Equal(expected, actual);
        }
    }
}
