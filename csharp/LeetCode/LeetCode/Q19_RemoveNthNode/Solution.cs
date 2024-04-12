using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q19_RemoveNthNode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) 
        {            
            var secondHead = head;
            for(var i = 0; i < n; i++)
            {
                secondHead = secondHead.next;
            }

            var front = new ListNode(0, head);
            head = front;
            while(secondHead != null)
            {
                head = head.next;
                secondHead = secondHead.next;
            }

            head.next = head?.next?.next;

            return front.next;
        }
    }
}
