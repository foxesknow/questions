using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q18_FourSum;

using NUnit.Framework;

namespace LeetCodeTests.Q18_FourSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{1,0,-1,0,-2,2}, 0);
            Assert.That(quads.Count, Is.EqualTo(3));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{2,2,2,2}, 8);
            Assert.That(quads.Count, Is.EqualTo(1));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{0,0,0,0}, 0);
            Assert.That(quads.Count, Is.EqualTo(1));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{1,-2,-5,-4,-3,3,3,5}, -11);
            Assert.That(quads.Count, Is.EqualTo(1));
        }

        [Test]
        public void Example5()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{-1,0,-5,-2,-2,-4,0,1,-2}, -9);
            Assert.That(quads.Count, Is.EqualTo(4));
        }

        [Test]
        public void Example6()
        {
            var s = new Solution();
            var quads = s.FourSum(new[]{1000000000,1000000000,1000000000,1000000000}, -294967296);
            Assert.That(quads.Count, Is.EqualTo(0));
        }
    }
}
