using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q38_CountAndSay;

using NUnit.Framework;

namespace LeetCodeTests.Q38_CountAndSay
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        [TestCase(4, "1211")]
        [TestCase(5, "111221")]
        public void CountAndSay(int count, string expected)
        {
            var s = new Solution();
            Assert.That(s.CountAndSay(count), Is.EqualTo(expected));
        }
    }
}
