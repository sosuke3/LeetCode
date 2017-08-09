using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.AddTwoNumbers
{
    public static class Solution
    {
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
    }
}
