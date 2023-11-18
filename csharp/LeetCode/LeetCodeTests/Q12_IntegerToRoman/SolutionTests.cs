using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q12_IntegerToRoman;

using NUnit.Framework;

namespace LeetCodeTests.Q12_IntegerToRoman
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var solution = new Solution();
            Assert.That(solution.IntToRoman(3), Is.EqualTo("III"));
        }

        [Test]
        public void Example2()
        {
            var solution = new Solution();
            Assert.That(solution.IntToRoman(58), Is.EqualTo("LVIII"));
        }

        [Test]
        public void Example3()
        {
            var solution = new Solution();
            Assert.That(solution.IntToRoman(1994), Is.EqualTo("MCMXCIV"));
        }
    }
}
