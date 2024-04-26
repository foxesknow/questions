using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q55_JumpGame;

using NUnit.Framework;

namespace LeetCodeTests.Q55_JumpGame
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var madeIt = s.CanJump(new[]{2,3,1,1,4});
            Assert.That(madeIt, Is.True);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var madeIt = s.CanJump(new[]{3,2,1,0,4});
            Assert.That(madeIt, Is.False);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var madeIt = s.CanJump(new[]{3,2,1,1,4});
            Assert.That(madeIt, Is.True);
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var madeIt = s.CanJump(new[]{0});
            Assert.That(madeIt, Is.True);
        }

        [Test]
        public void Example5()
        {
            var s = new Solution();
            var madeIt = s.CanJump(new[]{2,0,0});
            Assert.That(madeIt, Is.True);
        }
    }
}
