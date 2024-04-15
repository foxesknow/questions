using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q86_PartitionList
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x) 
        {
            ListNode leftHead = null, leftTail = null;
            ListNode rightHead = null, rightTail = null;

            while(head is not null)
            {
                var nextHead = head.next;
                head.next = null;

                if(head.val < x)
                {
                    if(leftHead is null)
                    {
                        leftHead = leftTail = head;
                    }
                    else
                    {
                        leftTail.next = head;
                        leftTail = head;
                    }
                }
                else
                {
                    if(rightHead is null)
                    {
                        rightHead = rightTail = head;
                    }
                    else
                    {
                        rightTail.next = head;
                        rightTail = head;
                    }
                }

                head = nextHead;
            }

            if(leftHead is null) return rightHead;
            
            // Join them
            leftTail.next = rightHead;

            return leftHead;
        }        
    }
}
