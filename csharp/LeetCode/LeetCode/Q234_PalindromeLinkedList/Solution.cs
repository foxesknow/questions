using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q234_PalindromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head) 
        {
            var length = Length(head);
            if(length == 1) return true;

            var halfWay = length / 2;

            // Reverse the first part of the list;
            ListNode reversed = null;
            for(int i = 0; i < halfWay; i++)
            {
                var next = head.next;
                head.next = reversed;
                reversed = head;
                head = next;
            }

            // If the length is odd then we can ignore the first item of the head
            if((length & 1) == 1) head = head.next;

            for(var i = 0; i < halfWay; i++)
            {
                if(reversed.val != head.val) return false;

                reversed = reversed.next;
                head = head.next;
            }

            return true;
        }

        private int Length(ListNode node)
        {
            var length = 0;

            while(node is not null)
            {
                length++;
                node = node.next;
            }

            return length;
        }
    }
}
