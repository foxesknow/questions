using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q63_UniquePaths2;
using NUnit.Framework;

namespace LeetCodeTests.Q63_UniquePaths2
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
                new[]{0,0,0},
                new[]{0,1,0},
                new[]{0,0,0},
            };

            Assert.That(s.UniquePathsWithObstacles(matrix), Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{0,1},
                new[]{0,0},
            };

            Assert.That(s.UniquePathsWithObstacles(matrix), Is.EqualTo(1));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{0,0,0},
                new[]{0,0,1},
                new[]{0,1,0},
            };

            Assert.That(s.UniquePathsWithObstacles(matrix), Is.EqualTo(0));
        }

        [Test]
        public void Example4()
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{0,0,0},
                new[]{0,0,0},
                new[]{0,0,1},
            };

            Assert.That(s.UniquePathsWithObstacles(matrix), Is.EqualTo(0));
        }
    }
}
