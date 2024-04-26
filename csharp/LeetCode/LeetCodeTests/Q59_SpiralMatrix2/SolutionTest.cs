using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q59_SpiralMatrix2;
using NUnit.Framework;

namespace LeetCodeTests.Q59_SpiralMatrix2
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var matrix = s.GenerateMatrix(3);
            Assert.That(matrix[0], Is.EqualTo(new[]{1,2,3}));
            Assert.That(matrix[1], Is.EqualTo(new[]{8,9,4}));
            Assert.That(matrix[2], Is.EqualTo(new[]{7,6,5}));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var matrix = s.GenerateMatrix(1);
            Assert.That(matrix[0], Is.EqualTo(new[]{1}));
        }
    }
}
