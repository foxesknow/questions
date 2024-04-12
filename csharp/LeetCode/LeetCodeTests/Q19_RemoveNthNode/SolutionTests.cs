using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using LeetCode.Q19_RemoveNthNode;

namespace LeetCodeTests.Q19_RemoveNthNode
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            ListNode n = new(1, new(2, new(3, new(4, new(5)))));
            var s = new Solution();
            var node = s.RemoveNthFromEnd(n, 2);
            Assert.That(node, Is.Not.Null);
        }

        [Test]
        public void Example2()
        {
            ListNode n = new(1);
            var s = new Solution();
            var node = s.RemoveNthFromEnd(n, 1);
            Assert.That(node, Is.Null);
        }

        [Test]
        public void Example3()
        {
            ListNode n = new(1, new(2));
            var s = new Solution();
            var node = s.RemoveNthFromEnd(n, 1);
            Assert.That(node, Is.Not.Null);
        }
    }
}
