using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q45_JumpGame2;
using NUnit.Framework;

namespace LeetCodeTests.Q45_JumpGame2
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var steps = s.Jump(new[]{2,3,1,1,4});
            Assert.That(steps, Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var steps = s.Jump(new[]{2,3,0,1,4});
            Assert.That(steps, Is.EqualTo(2));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var steps = s.Jump(new[]{5,6,4,4,6,9,4,4,7,4,4,8,2,6,8,1,5,9,6,5,2,7,9,7,9,6,9,4,1,6,8,8,4,4,2,0,3,8,5});
            Assert.That(steps, Is.EqualTo(2));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var steps = s.Jump(new[]{1,2,1,1,1});
            Assert.That(steps, Is.EqualTo(3));
        }
    }
}
