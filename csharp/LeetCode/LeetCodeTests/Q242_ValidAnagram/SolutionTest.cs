using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q242_ValidAnagram;
using NUnit.Framework;

namespace LeetCodeTests.Q242_ValidAnagram
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        public void Examples(string s, string t, bool expected)
        {
            var solution = new Solution();
            Assert.That(solution.IsAnagram(s, t), Is.EqualTo(expected));
        }
    }
}
