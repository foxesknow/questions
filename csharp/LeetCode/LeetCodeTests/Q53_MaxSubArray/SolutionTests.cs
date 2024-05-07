using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q53_MaxSubArray;
using NUnit.Framework;

namespace LeetCodeTests.Q53_MaxSubArray
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums = new int[]{-2,1,-3,4,-1,2,1,-5,4};
            Assert.That(s.MaxSubArray(nums), Is.EqualTo(6));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var nums = new int[]{5,4,-1,7,8};
            Assert.That(s.MaxSubArray(nums), Is.EqualTo(23));
        }
    }
}
