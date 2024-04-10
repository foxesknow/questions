using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q17_3SumClosest;

using NUnit.Framework;

namespace LeetCodeTests.Q17_3SumClosest
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var sum = s.ThreeSumClosest(new[]{-1,2,1,-4}, 1);
            Assert.That(sum, Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var sum = s.ThreeSumClosest(new[]{0,0,0}, 1);
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var sum = s.ThreeSumClosest(new[]{1,1,1}, 0);
            Assert.That(sum, Is.EqualTo(3));
        }
    }
}
