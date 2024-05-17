using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q48_RotateImage;
using NUnit.Framework;

namespace LeetCodeTests.Q48_RotateImage
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            int[][] matrix = new int[][]
            {
                new int[]{1, 2, 3},
                new int[]{4, 5, 6},
                new int[]{7, 8, 9},
            };

            s.Rotate(matrix);

            Assert.That(matrix[0], Is.EqualTo(new int[]{7, 4, 1}));
            Assert.That(matrix[1], Is.EqualTo(new int[]{8, 5, 2}));
            Assert.That(matrix[2], Is.EqualTo(new int[]{9, 6, 3}));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            int[][] matrix = new int[][]
            {
                new int[]{1}
            };

            s.Rotate(matrix);

            Assert.That(matrix[0], Is.EqualTo(new int[]{1}));
        }
    }
}
