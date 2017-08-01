using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.TwoSum
{
    public static class Solution
    {
        public static int[] TwoSum(int [] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            
            for(int i=0; i<nums.Length; i++)
            {
                int diff = target - nums[i];
                if(hash.ContainsKey(diff))
                {
                    return new int[] { hash[diff], i };
                }
                hash[nums[i]] = i;
            }

            return null;
        }
    }
}
