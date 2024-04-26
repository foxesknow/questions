using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q75_SortColors;
using NUnit.Framework;

namespace LeetCodeTests.Q75_SortColors
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var colors = new int[]{2,0,2,1,1,0};
            s.SortColors(colors);
            Assert.That(colors, Is.EqualTo(new int[]{0,0,1,1,2,2,}));
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            var colors = new int[]{2,0,1};
            s.SortColors(colors);
            Assert.That(colors, Is.EqualTo(new int[]{0,1,2}));
        }
    }
}
