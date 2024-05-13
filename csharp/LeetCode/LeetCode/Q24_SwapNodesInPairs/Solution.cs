using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q24_SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head) 
        {
            if(head is null || head.next is null) return head;

            ListNode swapHead = null;
            ListNode tail = null;

            while(head is not null)
            {
                if(head.next is null)
                {
                    if(swapHead is null)
                    {
                        swapHead = head;
                        
                    }
                    else
                    {
                        tail.next = head;
                    }

                    head = head.next;
                }
                else
                {
                    // There's at least 2 items in from
                    var newHead = head.next.next;

                    var swap = head.next;
                    swap.next = head;
                    swap.next.next = null;

                    if(swapHead is null)
                    {
                        swapHead = swap;                        
                    }
                    else
                    {
                        tail.next = swap;
                    }

                    tail = swap.next;
                    head = newHead;
                }
            }

            return swapHead;
        }
    }
}
