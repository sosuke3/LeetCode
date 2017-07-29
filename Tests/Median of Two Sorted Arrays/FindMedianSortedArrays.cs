using System;
using System.Linq;
using Xunit;

namespace Tests.FindMedianSortedArrays
{
    public class FindMedianSortedArrays
    {
        [Theory]
        [InlineData(new int[] { 1,3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1,2 }, new int[] { 3,4 }, 2.5)]
        public void TestFindMedianSortedArrays(int [] nums1, int [] nums2, double expected)
        {
            var actual = Problems.FindMedianSortedArrays.Solution.FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, actual);
        }
    }
}
