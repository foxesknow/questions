using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q71_SimplifyPath;
using NUnit.Framework;

namespace LeetCodeTests.Q71_SimplifyPath
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("/home/", "/home")]
        [TestCase("/../", "/")]
        [TestCase("/home//foo/", "/home/foo")]
        public void Examples(string path, string expected)
        {
            var s = new Solution();
            Assert.That(s.SimplifyPath(path), Is.EqualTo(expected));
        }
    }
}
