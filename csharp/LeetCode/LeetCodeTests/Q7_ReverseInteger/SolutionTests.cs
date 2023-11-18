using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q7_ReverseInteger;

using NUnit.Framework;

namespace LeetCodeTests.Q7_ReverseInteger
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var solution = new Solution();
            Assert.That(solution.Reverse(123), Is.EqualTo(321));
        }

        [Test]
        public void Example2()
        {
            var solution = new Solution();
            Assert.That(solution.Reverse(-123), Is.EqualTo(-321));
        }

        [Test]
        public void Example3()
        {
            var solution = new Solution();
            Assert.That(solution.Reverse(120), Is.EqualTo(21));
        }
    }
}
