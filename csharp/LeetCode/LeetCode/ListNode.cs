using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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

        public ListNode Skip(int count)
        {
            var head = this;

            while(count-- != 0)
            {
                head = head.next;
            }

            return head;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        public static ListNode Make(params int[] values)
        {
            ListNode head = null;

            for(var i = values.Length - 1; i >= 0; i--)
            {
                head= new ListNode(values[i], head);
            }

            return head;
        }
    }
}
