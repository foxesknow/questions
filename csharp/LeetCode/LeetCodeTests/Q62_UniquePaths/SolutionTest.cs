using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q62_UniquePaths;

using NUnit.Framework;

namespace LeetCodeTests.Q62_UniquePaths
{
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var paths = s.UniquePaths(3, 7);
            Assert.That(paths, Is.EqualTo(28));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var paths = s.UniquePaths(3, 2);
            Assert.That(paths, Is.EqualTo(3));
        }
    }
}
