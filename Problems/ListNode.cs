using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /**
     * Definition for singly-linked list.
     */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode BuildFromArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            var ret = new ListNode(nums[0]);
            ret.next = BuildFromArray(nums.Skip(1).ToArray());
            return ret;
        }

        public int[] ToArray()
        {
            List<int> ret = new List<int>();
            ret.Add(this.val);

            if (this.next != null)
            {
                var nextArray = this.next.ToArray();
                if (nextArray.Length > 0)
                {
                    ret.AddRange(nextArray);
                }
            }

            return ret.ToArray();
        }
    }
}
