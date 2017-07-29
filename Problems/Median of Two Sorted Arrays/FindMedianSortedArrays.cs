using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.FindMedianSortedArrays
{
    public static class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if(nums1.Length == 0 && nums2.Length == 0)
            {
                return 0.0;
            }

            int total = nums1.Length + nums2.Length;
            int middle = (total + 1) / 2;
            bool isEvenTotal = (total % 2) == 0;
            int i = 0, j = 0;
            int first = 0, second = 0;
            int last = 0, current = 0;
            int count = 0;

            for(;;)
            {
                if(i < nums1.Length)
                {
                    first = nums1[i];
                }
                else
                {
                    first = int.MaxValue;
                }
                if (j < nums2.Length)
                {
                    second = nums2[j];
                }
                else
                {
                    second = int.MaxValue;
                }

                if(first < second)
                {
                    current = first;
                    i++;
                }
                else
                {
                    current = second;
                    j++;
                }

                count++;


                if (count > middle)
                {
                    if (isEvenTotal)
                    {
                        return ((double)last + (double)current) / 2.0;
                    }
                    else
                    {
                        return last;
                    }
                }

                last = current;
            }
        }

        public static string Run()
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };

            //int[] nums1 = new int[] { 1, 2 };
            //int[] nums2 = new int[] { 3, 4 };

            return FindMedianSortedArrays(nums1, nums2).ToString();
        }
    }
}
