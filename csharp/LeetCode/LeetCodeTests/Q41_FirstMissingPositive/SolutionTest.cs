using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q41_FirstMissingPositive;
using NUnit.Framework;

namespace LeetCodeTests.Q41_FirstMissingPositive
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,2,0});
            Assert.That(first, Is.EqualTo(3));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{3,4,-1,1});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{7,8,9,11,12});
            Assert.That(first, Is.EqualTo(1));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,1});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example5()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,1000});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example6()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,2,3,4,5,6,7,8,9,10,11,12,23,20});
            Assert.That(first, Is.EqualTo(13));
        }

        [Test]
        public void Example7()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,1,1,3});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example8()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example9()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{1,3,3});
            Assert.That(first, Is.EqualTo(2));
        }

        [Test]
        public void Example10()
        {
            var s = new Solution();
            var first = s.FirstMissingPositive(new[]{2,2,4,0,1,3,3,3,4,3});
            Assert.That(first, Is.EqualTo(5));
        }
    }
}
