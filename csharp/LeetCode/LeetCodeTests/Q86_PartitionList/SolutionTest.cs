using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q86_PartitionList;

using NUnit.Framework;

namespace LeetCodeTests.Q86_PartitionList
{
    [TestFixture]
    public class SolutionTest : SolutionTestBase
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            ListNode node = new(1, new(4, new(3, new(2, new(5, new(2))))));
            var result = s.Partition(node, 3);
            Assert.That(result, Is.Not.Null);
            EnsureListEquals(result, 1, 2, 2, 4, 3, 5);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            ListNode node = new(1, new(2));
            var result = s.Partition(node, 2);
            Assert.That(result, Is.Not.Null);
            EnsureListEquals(result, 1, 2);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            ListNode node = new(1, new(4, new(3, new(2, new(5, new(2))))));
            var result = s.Partition(node, 10);
            Assert.That(result, Is.Not.Null);
            EnsureListEquals(result, 1, 4, 3, 2, 5, 2);
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            ListNode node = new(1, new(4, new(3, new(2, new(5, new(2))))));
            var result = s.Partition(node, -10);
            Assert.That(result, Is.Not.Null);
            EnsureListEquals(result, 1, 4, 3, 2, 5, 2);
        }
    }
}
