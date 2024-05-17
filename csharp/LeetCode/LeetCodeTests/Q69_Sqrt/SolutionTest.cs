using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q69_Sqrt;
using NUnit.Framework;

namespace LeetCodeTests.Q69_Sqrt
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        [TestCase(121, 11)]
        [TestCase(196, 14)]
        [TestCase(8, 2)]
        [TestCase(85, 9)]
        [TestCase(2147395599, 46339)]
        public void Examples(int value, int expected)
        {
            var s = new Solution();
            Assert.That(s.MySqrt(value), Is.EqualTo(expected));
        }
    }
}
