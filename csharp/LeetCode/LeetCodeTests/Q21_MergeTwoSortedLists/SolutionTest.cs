using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q21_MergeTwoSortedLists;
using NUnit.Framework;

namespace LeetCodeTests.Q21_MergeTwoSortedLists
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var list1 = ListNode.Make(1, 2, 4);
            var list2 = ListNode.Make(1, 3, 4);
            var merged = s.MergeTwoLists(list1, list2);
            Check(merged, 1, 1, 2, 3, 4, 4);
        }

        private void Check(ListNode node, params int[] values)
        {
            foreach(var value in values)
            {
                Assert.That(node.val, Is.EqualTo(value));
                node = node.next;
            }
        }
    }
}
