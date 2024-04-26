using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q64_MinimumPathSum;
using NUnit.Framework;

namespace LeetCodeTests.Q64_MinimumPathSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{1,3,1},
                new[]{1,5,1},
                new[]{4,2,1},
            };

            Assert.That(s.MinPathSum(matrix), Is.EqualTo(7));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{1,2,3},
                new[]{4,5,6},
            };

            Assert.That(s.MinPathSum(matrix), Is.EqualTo(12));
        }
    }
}
