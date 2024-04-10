using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q15_3Sum;

using NUnit.Framework;

namespace LeetCodeTests.Q15_3Sum
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var triplets = s.ThreeSum(new[]{-1,0,1,2,-1,-4});
            Assert.That(triplets.Count, Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var triplets = s.ThreeSum(new[]{0,1,1});
            Assert.That(triplets.Count, Is.EqualTo(0));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var triplets = s.ThreeSum(new[]{0,0,0});
            Assert.That(triplets.Count, Is.EqualTo(1));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var triplets = s.ThreeSum(new[]{-2,0,0,2,2});
            Assert.That(triplets.Count, Is.EqualTo(1));
        }
    }
}
