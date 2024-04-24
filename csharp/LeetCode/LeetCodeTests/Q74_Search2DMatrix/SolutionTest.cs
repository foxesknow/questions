using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q74_Search2DMatrix;

using NUnit.Framework;

namespace LeetCodeTests.Q74_Search2DMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(3, true)]
        [TestCase(13, false)]
        [TestCase(0, false)]
        [TestCase(999, false)]
        [TestCase(1, true)]
        [TestCase(60, true)]
        public void Example1(int target, bool expected)
        {
            var s = new Solution();
            var matrix = new int[][]
            {
                new[]{1,3,5,7},
                new[]{10,11,16,20},
                new[]{23,30,34,60}
            };

            Assert.That(s.SearchMatrix(matrix, target), Is.EqualTo(expected));
        }
    }
}
