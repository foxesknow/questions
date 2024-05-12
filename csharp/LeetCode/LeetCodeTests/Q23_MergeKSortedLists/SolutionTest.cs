using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;
using LeetCode.Q23_MergeKSortedLists;
using NUnit.Framework;

namespace LeetCodeTests.Q23_MergeKSortedLists
{
    [TestFixture]
    public class SolutionTest : SolutionTestBase
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var lists = new ListNode[]
            {
                ListNode.Make(1, 4, 5),
                ListNode.Make(1, 3, 4),
                ListNode.Make(2, 6),
            };

            var merged = s.MergeKLists(lists);
            EnsureListEquals(merged, 1, 1, 2, 3, 4, 4, 5, 6);
        }
    }
}
