using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q39_CombinationSum;

using NUnit.Framework;

namespace LeetCodeTests.Q39_CombinationSum
{
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var results = s.CombinationSum(new[]{2,3,6,7}, 7);
            Assert.That(results, Has.Count.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var results = s.CombinationSum(new[]{2,3,5}, 8);
            Assert.That(results, Has.Count.EqualTo(3));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var results = s.CombinationSum(new[]{2}, 1);
            Assert.That(results, Has.Count.EqualTo(0));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var results = s.CombinationSum(new[]{2,3,6,7}, 7);
            Assert.That(results, Has.Count.EqualTo(2));
        }
    }
}
