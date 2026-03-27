using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q21_MergeTwoSortedLists;

/// <summary>
/// There won't be more that 50 nodes in either list, so we can use recursion
/// </summary>
public class RecursiveSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 is null) return list2;
        if(list2 is null) return list1;

        if(list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    public ListNode TailMergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;

        Recurse(ref head, list1, list2);

        return head;

        static void Recurse(ref ListNode tail, ListNode list1, ListNode list2)
        {
            if(list1 is null)
            {
                tail = list2;
                return;
            }

            if(list2 is null)
            {
                tail = list1;
                return;
            }

            if(list1.val < list2.val)
            {
                tail = list1;
                Recurse(ref tail.next, list1.next, list2);
            }
            else
            {
                tail = list2;
                Recurse(ref tail.next, list1, list2.next);
            }
        }
    }
}
