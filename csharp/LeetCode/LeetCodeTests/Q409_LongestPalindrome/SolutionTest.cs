using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q409_LongestPalindrome;
using NUnit.Framework;

namespace LeetCodeTests.Q409_LongestPalindrome
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("abccccdd", 7)]
        [TestCase("a", 1)]
        [TestCase("Aa", 1)]
        public void Examples(string input, int count)
        {
            var s = new Solution();
            Assert.That(s.LongestPalindrome(input), Is.EqualTo(count));
        }
    }
}
