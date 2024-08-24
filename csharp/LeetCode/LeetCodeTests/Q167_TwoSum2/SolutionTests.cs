using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q167_TwoSum2;

using NUnit.Framework;

namespace LeetCodeTests.Q167_TwoSum2
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        [TestCase(new int[]{2, 7, 11, 15}, 9, new int[]{1, 2})]
        [TestCase(new int[]{2, 3, 4}, 6, new int[]{1, 3})]
        [TestCase(new int[]{-1, 0}, -1, new int[]{1, 2})]
        public void TwoSum(int[] values, int sum, int[] expected)
        {
            var s = new Solution();
            var results = s.TwoSum(values, sum);
            Assert.That(results[0], Is.EqualTo(expected[0]));
            Assert.That(results[1], Is.EqualTo(expected[1]));
        }
    }
}
