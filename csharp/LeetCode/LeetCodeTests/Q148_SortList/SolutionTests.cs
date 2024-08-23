using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q148_SortList;

using NUnit.Framework;

namespace LeetCodeTests.Q148_SortList
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        [TestCase(new int[]{})]
        [TestCase(new int[]{1})]
        [TestCase(new int[]{4, 2, 1, 3})]
        [TestCase(new int[]{-1, 5, 3, 4, 0})]
        public void Sort(int[] values)
        {
            var head = ListNode.Make(values);

            var s = new Solution();
            var result = s.SortList(head);

            Array.Sort(values);
            var index = 0;

            while(result is not null)
            {
                Assert.That(result.val, Is.EqualTo(values[index]));
                index++;
                result = result.next;
            }
        }
    }
}
