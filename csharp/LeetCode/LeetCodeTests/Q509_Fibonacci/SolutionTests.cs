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

        [Test]
        public void CacheExample1()
        {
            var s = new Solution();
            Assert.That(s.FibCache(2), Is.EqualTo(1));
        }

        [Test]
        public void CacheExample2()
        {
            var s = new Solution();
            Assert.That(s.FibCache(3), Is.EqualTo(2));
        }

        [Test]
        public void CacheExample3()
        {
            var s = new Solution();
            Assert.That(s.FibCache(4), Is.EqualTo(3));
        }

        [Test]
        public void CacheExample4()
        {
            var s = new Solution();
            
            // The largest fib that can fit in a signed 32 bit int is 1,836,311,903
            Assert.That(s.FibCache(46), Is.EqualTo(1_836_311_903));
        }

        [Test]
        public void LinqExample1()
        {
            var s = new Solution();
            Assert.That(s.FibLinq(2), Is.EqualTo(1));
        }

        [Test]
        public void LinqExample2()
        {
            var s = new Solution();
            Assert.That(s.FibLinq(3), Is.EqualTo(2));
        }

        [Test]
        public void LinqExample3()
        {
            var s = new Solution();
            Assert.That(s.FibLinq(4), Is.EqualTo(3));
        }

        [Test]
        public void LinqExample4()
        {
            var s = new Solution();
            
            // The largest fib that can fit in a signed 32 bit int is 1,836,311,903
            Assert.That(s.FibLinq(46), Is.EqualTo(1_836_311_903));
        }
    }
}
