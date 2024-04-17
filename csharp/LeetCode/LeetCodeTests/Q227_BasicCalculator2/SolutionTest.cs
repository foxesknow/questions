using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q227_BasicCalculator2;

using NUnit.Framework;

namespace LeetCodeTests.Q227_BasicCalculator2
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("3+2*2", 7)]
        [TestCase(" 3   +  2   *   2   ", 7)]
        public void Example1(string expression, int expected)
        {
            var s = new Solution();
            var result = s.Calculate(expression);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("3/2", 1)]
        public void Example2(string expression, int expected)
        {
            var s = new Solution();
            var result = s.Calculate(expression);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("2+3-4", 1)]
        public void Example3(string expression, int expected)
        {
            var s = new Solution();
            var result = s.Calculate(expression);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("1*2-3/4+5*6-7*8+9/10", -24)]
        public void Example4(string expression, int expected)
        {
            var s = new Solution();
            var result = s.Calculate(expression);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
