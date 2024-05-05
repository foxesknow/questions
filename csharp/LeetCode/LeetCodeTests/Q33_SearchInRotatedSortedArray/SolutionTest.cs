using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q33_SearchInRotatedSortedArray;
using NUnit.Framework;

namespace LeetCodeTests.Q33_SearchInRotatedSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(4, 0)]
        [TestCase(5, 1)]
        [TestCase(6, 2)]
        [TestCase(7, 3)]
        [TestCase(0, 4)]
        [TestCase(1, 5)]
        [TestCase(2, 6)]
        [TestCase(-10, -1)]
        [TestCase(100, -1)]
        public void Example1(int value, int expectedIndex)
        {
            var s = new Solution();
            var numbers = new int[]{4,5,6,7,0,1,2};
            Assert.That(s.Search(numbers, value), Is.EqualTo(expectedIndex));
        }
    }
}
