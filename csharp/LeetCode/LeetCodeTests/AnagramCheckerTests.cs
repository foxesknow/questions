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
    public class AnagramCheckerTests
    {
        [Test]
        [TestCase("Cat", "cat", true)]
        [TestCase("Cat", "act", true)]
        [TestCase("Cat", "ac", false)]
        [TestCase("Hello", "hell", false)]
        public void Examples(string word1, string word2, bool expected)
        {
            var s = new AnagramChecker();
            Assert.That(s.IsAnagram(word1, word2), Is.EqualTo(expected));
        }
    }
}
