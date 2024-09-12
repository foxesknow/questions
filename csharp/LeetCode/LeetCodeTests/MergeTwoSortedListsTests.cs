using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;

using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class MergeTwoSortedListsTests
    {
        [Test]
        [TestCase(new int[]{1, 2, 3}, new int[]{})]
        [TestCase(new int[]{}, new int[]{1, 2, 3})]
        [TestCase(new int[]{1, 2, 3}, new int[]{1, 2, 3})]
        [TestCase(new int[]{1, 2, 3}, new int[]{4, 5, 6})]
        [TestCase(new int[]{1, 2, 3, 15}, new int[]{4, 5, 6, 7, 8, 9})]
        public void Merge(int[] left, int[] right)
        {
            var expected = new List<int>();
            expected.AddRange(left);
            expected.AddRange(right);
            expected.Sort();

            var merger = new MergeTwoSortedLists();
            var result = merger.Merge(left, right);

            Assert.That(result, Is.EqualTo(expected.ToArray()));
        }
    }
}
