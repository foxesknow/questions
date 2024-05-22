using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q3105_LongestIncreasingOrDecreasing;
using NUnit.Framework;

namespace LeetCodeTests.Q3105_LongestIncreasingOrDecreasing
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums = new int[]{1, 4, 3, 3, 2};
            Assert.That(s.LongestMonotonicSubarray(nums), Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var nums = new int[]{3, 3, 3, 3};
            Assert.That(s.LongestMonotonicSubarray(nums), Is.EqualTo(1));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var nums = new int[]{3, 2, 1};
            Assert.That(s.LongestMonotonicSubarray(nums), Is.EqualTo(3));
        }
    }
}
