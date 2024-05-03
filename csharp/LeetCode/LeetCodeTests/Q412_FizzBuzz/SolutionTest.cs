using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q412_FizzBuzz;
using NUnit.Framework;

namespace LeetCodeTests.Q412_FizzBuzz
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var results = s.FizzBuzz(3);
            Assert.That(results, Is.EqualTo(new[]{"1", "2", "Fizz"}));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var results = s.FizzBuzz(5);
            Assert.That(results, Is.EqualTo(new[]{"1", "2", "Fizz", "4", "Buzz"}));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var results = s.FizzBuzz(15);
            Assert.That(results, Is.EqualTo(new[]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"}));
        }
    }
}
