using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q80_RemoveDuplicatesFromSortedArray;
using NUnit.Framework;

namespace LeetCodeTests.Q80_RemoveDuplicatesFromSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums = new int[]{1,1,1,2,2,3};
            Assert.That(s.RemoveDuplicates(nums), Is.EqualTo(5));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var nums = new int[]{0,0,1,1,1,1,2,3,3};
            Assert.That(s.RemoveDuplicates(nums), Is.EqualTo(7));
        }
    }
}
