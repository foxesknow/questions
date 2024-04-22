using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q56_MergeIntervals;

using NUnit.Framework;

namespace LeetCodeTests.Q56_MergeIntervals
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            int[][] intervals = [[1,3],[2,6],[8,10],[15,18]];
            var merged = s.Merge(intervals);
            Assert.That(merged.Count, Is.EqualTo(3));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            int[][] intervals = [[1,4],[4,5]];
            var merged = s.Merge(intervals);
            Assert.That(merged.Count, Is.EqualTo(1));
        }

        [Test]
        public void Example3()
        {
            var s = new Solution();
            int[][] intervals = [[1,4],[2,3]];
            var merged = s.Merge(intervals);
            Assert.That(merged.Count, Is.EqualTo(1));
        }
    }
}
