using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q24_SwapNodesInPairs;
using NUnit.Framework;

namespace LeetCodeTests.Q24_SwapNodesInPairs
{
    [TestFixture]
    public class SolutionTest : SolutionTestBase
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4);
            var swapped = s.SwapPairs(list);
            EnsureListEquals(swapped, 2, 1, 4, 3);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4);
            var swapped = s.SwapPairs(null);
            Assert.That(swapped, Is.Null);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var list = ListNode.Make(1);
            var swapped = s.SwapPairs(list);
            EnsureListEquals(swapped, 1);
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3);
            var swapped = s.SwapPairs(list);
            EnsureListEquals(swapped, 2, 1, 3);
        }

        [Test]
        public void Example5()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4, 5);
            var swapped = s.SwapPairs(list);
            EnsureListEquals(swapped, 2, 1, 4, 3, 5);
        }
    }
}
