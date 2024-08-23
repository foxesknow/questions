using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q148_SortList
{
    public class Solution
    {
        public ListNode SortList(ListNode head) 
        {
            if(head is null || head.next is null) return head;

            var mid = GetMidpoint(head);
            var left = head;
            var right = mid.next;
            mid.next = null;

            var sortedLeft = SortList(left);
            var sortedRight = SortList(right);

            return Combine(sortedLeft, sortedRight);
        }

        private ListNode Combine(ListNode left, ListNode right)
        {
            if(left is null) return right;
            if(right is null) return left;

            if(left.val <= right.val)
            {
                left.next = Combine(left.next, right);
                return left;
            }
            else
            {
                right.next = Combine(left, right.next);
                return right;
            }
        }

        private ListNode GetMidpoint(ListNode node)
        {
            var fastNode = node;

            while(fastNode.next?.next is not null)
            {
                node = node.next;
                fastNode = fastNode.next.next;
            }

            return node;
        }
    }
}
