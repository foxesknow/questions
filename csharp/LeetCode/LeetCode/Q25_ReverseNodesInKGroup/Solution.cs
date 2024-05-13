using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q25_ReverseNodesInKGroup
{
    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var (reversedHead, tail, node) = ReverseGroup(head, k);

            while(node is not null)
            {
                var (h, t, n) = ReverseGroup(node, k);

                tail.next = h;
                tail = t;
                node = n;
            }

            return reversedHead;
        }

        private bool CanConsume(ListNode list, int count)
        {
            for(int i = 0; i < count; i++)
            {
                if(list is null) return false;

                list = list.next;
            }

            return true;
        }

        private (ListNode GroupHead, ListNode GroupTail, ListNode Tail) ReverseGroup(ListNode node, int k)
        {
            if(!CanConsume(node, k)) return (node, null, null);

            ListNode head = null;
            ListNode tail = null;

            for(int i = 0; i < k && node is not null; i++)
            {
                var next = node.next;

                if(head is null)
                {
                    head = tail = node;
                    node.next = null;
                }
                else
                {
                    node.next = head;
                    head = node;
                }

                node = next;
            }

            return (head, tail, node);
        }
    }
}
