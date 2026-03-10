using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q509_Fibonacci;
using NUnit.Framework;

namespace LeetCodeTests.Q509_Fibonacci
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            Assert.That(s.Fib(2), Is.EqualTo(1));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            Assert.That(s.Fib(3), Is.EqualTo(2));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            Assert.That(s.Fib(4), Is.EqualTo(3));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            
            // The largest fib that can fit in a signed 32 bit int is 1,836,311,903
            Assert.That(s.Fib(46), Is.EqualTo(1_836_311_903));
        }
    }
}
