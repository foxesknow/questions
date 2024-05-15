using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q34_FindFirstAndLast;
using NUnit.Framework;

namespace LeetCodeTests.Q34_FindFirstAndLast
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums = new int[]{5,7,7,8,8,10};
            var indexes = s.SearchRange(nums, 8);
            Assert.That(indexes[0], Is.EqualTo(3));
            Assert.That(indexes[1], Is.EqualTo(4));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var nums = new int[]{5,7,7,8,8,10};
            var indexes = s.SearchRange(nums, 6);
            Assert.That(indexes[0], Is.EqualTo(-1));
            Assert.That(indexes[1], Is.EqualTo(-1));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var nums = new int[]{};
            var indexes = s.SearchRange(nums, 0);
            Assert.That(indexes[0], Is.EqualTo(-1));
            Assert.That(indexes[1], Is.EqualTo(-1));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var nums = new int[]{5,7,7,8,8,10};
            var indexes = s.SearchRange(nums, 10);
            Assert.That(indexes[0], Is.EqualTo(5));
            Assert.That(indexes[1], Is.EqualTo(5));
        }
    }
}
