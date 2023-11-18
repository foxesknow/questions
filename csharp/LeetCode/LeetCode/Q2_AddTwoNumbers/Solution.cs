using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q2_AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            int carry = 0;

            ListNode head = null;
            ListNode next = null;

            while(l1 is not null || l2 is not null || carry != 0)
            {
                var sum = carry;

                if(l1 is not null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 is not null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                var node = new ListNode(sum % 10);
                carry = sum / 10;

                if(next is null)
                {
                    head = next = node;
                }
                else
                {
                    next.next = node;
                    next = node;
                }
            }

            return head;
        }
    }
}
