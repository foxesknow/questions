using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q3151_SpecialArray1;
using NUnit.Framework;

namespace LeetCodeTests.Q3151_SpecialArray1
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var nums = new int[]{1};
            Assert.That(s.IsArraySpecial(nums), Is.True);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var nums = new int[]{2, 1, 4};
            Assert.That(s.IsArraySpecial(nums), Is.True);
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var nums = new int[]{4, 3, 1, 6};
            Assert.That(s.IsArraySpecial(nums), Is.False);
        }
    }
}
