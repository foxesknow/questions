using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q13_RomanToInteger;
using NUnit.Framework;

namespace LeetCodeTests.Q13_RomanToInteger
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void Examples(string roman, int expected)
        {
            var s = new Solution();
            Assert.That(s.RomanToInt(roman), Is.EqualTo(expected));
        }
    }
}
