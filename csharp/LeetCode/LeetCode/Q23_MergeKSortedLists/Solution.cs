using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q23_MergeKSortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists) 
        {
            if(lists.Length == 0) return null;
            if(lists.Length == 1) return lists[0];

            var merged = lists.Aggregate((ListNode)null, (acc, list) => MergeTwoLists(acc, list));
            return merged;
        }

        private ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            if(list1 is null) return list2;
            if(list2 is null) return list1;

            var head = Next(ref list1, ref list2);
            var tail = head;

            while(list1 is not null && list2 is not null)
            {
                var smallest = Next(ref list1, ref list2);
                tail.next = smallest;
                tail = smallest;
            }

            tail.next = (list1 is not null ? list1 : list2);

            return head;
        }

        private ListNode Next(ref ListNode list1, ref ListNode list2)
        {
            if(list1.val < list2.val)
            {
                var node = list1;
                list1 = list1.next;

                return node;
            }
            else
            {
                var node = list2;
                list2 = list2.next;

                return node;
            }
        }
    }
}
