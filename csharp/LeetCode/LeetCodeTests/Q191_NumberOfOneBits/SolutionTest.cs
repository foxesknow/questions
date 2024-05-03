using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q191_NumberOfOneBits;
using NUnit.Framework;

namespace LeetCodeTests.Q191_NumberOfOneBits
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(11, 3)]
        [TestCase(128, 1)]
        [TestCase(0, 0)]
        [TestCase(2147483645, 30)]
        [TestCase(int.MaxValue, 31)]
        public void Examples(int number, int expected)
        {
            var s = new Solution();
            Assert.That(s.HammingWeight(number), Is.EqualTo(expected));
        }
    }
}
