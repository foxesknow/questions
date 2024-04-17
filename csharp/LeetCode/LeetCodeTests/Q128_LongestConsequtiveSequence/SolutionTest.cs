using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q128_LongestConsequtiveSequence;
using NUnit.Framework;

namespace LeetCodeTests.Q128_LongestConsequtiveSequence
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var longest = s.LongestConsecutive(new[]{100,4,200,1,3,2});
            Assert.That(longest, Is.EqualTo(4));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var longest = s.LongestConsecutive(new[]{0,3,7,2,5,8,4,6,0,1});
            Assert.That(longest, Is.EqualTo(9));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var longest = s.LongestConsecutive(new[]{1,2,0,1});
            Assert.That(longest, Is.EqualTo(3));
        }
    }
}
