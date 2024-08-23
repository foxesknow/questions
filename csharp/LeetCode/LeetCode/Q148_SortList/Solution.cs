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
            ListNode head = null;
            ListNode tail = null;

            while(left is not null && right is not null)
            {
                if(left.val <= right.val)
                {
                    if(head is null)
                    {
                        head = tail = left;
                    }
                    else
                    {
                        tail.next = left;
                        tail = left;
                    }

                    left = left.next;
                    tail.next = null;
                }
                else
                {
                    if(head is null)
                    {
                        head = tail = right;
                    }
                    else
                    {
                        tail.next = right;
                        tail = right;
                    }

                    right = right.next;
                    tail.next = null;
                }
            }

            if(left is not null)
            {
                tail.next = left;
            }
            else
            {
                tail.next = right;
            }

            return head;
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
