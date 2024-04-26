using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q283_MoveZeros;

using NUnit.Framework;

namespace LeetCodeTests.Q283_MoveZeros
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var numbers = new[]{0,1,0,3,12};
            s.MoveZeroes(numbers);
            Assert.That(numbers, Is.EqualTo(new[]{1,3,12,0,0}));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var numbers = new[]{0};
            s.MoveZeroes(numbers);
            Assert.That(numbers, Is.EqualTo(new[]{0}));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var numbers = new[]{8};
            s.MoveZeroes(numbers);
            Assert.That(numbers, Is.EqualTo(new[]{8}));
        }
    }
}
