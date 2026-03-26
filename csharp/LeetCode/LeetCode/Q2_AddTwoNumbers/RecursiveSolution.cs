using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q2_AddTwoNumbers;

/// <summary>
/// The question says there won't be more than 100 nodes on either side
/// </summary>
public class RecursiveSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        return Recurse(0, l1, l2);
    }

    private ListNode Recurse(int carry, ListNode l1, ListNode l2) 
    {
        if(l1 is null && carry == 0) return l2;
        if(l2 is null && carry == 0) return l1;

        var sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);

        return new ListNode(sum % 10, Recurse(sum / 10, l1?.next, l2?.next));
    }
}
