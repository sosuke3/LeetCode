using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.AddTwoNumbers
{
    public static class Solution
    {
        /**
         * Definition for singly-linked list.
         */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public static ListNode BuildFromArray(int [] nums)
            {
                if(nums.Length == 0)
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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry=0)
        {
            int val1=0, val2=0;
            ListNode next1=null, next2=null;
            if (l1 != null)
            {
                val1 = l1.val;
                next1 = l1.next;
            }
            if (l2 != null)
            {
                val2 = l2.val;
                next2 = l2.next;
            }

            int digit = val1 + val2 + carry;

            int remainder = 0;

            if (digit > 9)
            {
                remainder = 1;
                digit = digit - 10;
            }

            var ret = new ListNode(digit);

            if (next1 != null || next2 != null || remainder > 0)
            {
                ret.next = AddTwoNumbers(next1, next2, remainder);
            }

            return ret;
        }

        public static string Run()
        {
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(5);

            //ListNode l1 = new ListNode(2);
            //ListNode l2 = new ListNode(5);

            //l1.next = new ListNode(4);
            //l2.next = new ListNode(6);

            //l1.next.next = new ListNode(3);
            //l2.next.next = new ListNode(4);

            ListNode output = AddTwoNumbers(l1, l2);

            return PrintNode(output);
        }

        public static string PrintNode(ListNode node)
        {
            string ret = node.val.ToString();
            if(node.next != null)
            {
                ret += " -> ";
                ret += PrintNode(node.next);
            }
            return ret;
        }
    }
}
