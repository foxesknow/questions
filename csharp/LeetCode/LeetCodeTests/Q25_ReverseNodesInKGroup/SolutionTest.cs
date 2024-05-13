using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q25_ReverseNodesInKGroup;
using NUnit.Framework;

namespace LeetCodeTests.Q25_ReverseNodesInKGroup
{
    [TestFixture]
    public class SolutionTest : SolutionTestBase
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4, 5);
            var reversed = s.ReverseKGroup(list, 2);
            EnsureListEquals(reversed, 2, 1, 4, 3, 5);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4, 5);
            var reversed = s.ReverseKGroup(list, 3);
            EnsureListEquals(reversed, 3, 2, 1, 4, 5);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4, 5);
            var reversed = s.ReverseKGroup(list, 5);
            EnsureListEquals(reversed, 5, 4, 3, 2, 1);
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var list = ListNode.Make(1, 2, 3, 4, 5);
            var reversed = s.ReverseKGroup(list, 6);
            EnsureListEquals(reversed, 1, 2, 3, 4, 5);
        }
    }
}
