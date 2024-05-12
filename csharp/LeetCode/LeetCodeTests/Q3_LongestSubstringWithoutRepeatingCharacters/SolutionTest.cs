using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q3_LongestSubstringWithoutRepeatingCharacters;
using NUnit.Framework;

namespace LeetCodeTests.Q3_LongestSubstringWithoutRepeatingCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("a", 1)]
        [TestCase("", 0)]
        [TestCase("abcdefg", 7)]
        [TestCase("tmmzuxt", 5)]
        public void Examples(string value, int expected)
        {
            var s = new Solution();
            Assert.That(s.LengthOfLongestSubstring(value), Is.EqualTo(expected));
        }
    }
}
