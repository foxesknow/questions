using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q3136_ValidWord;
using NUnit.Framework;

namespace LeetCodeTests.Q3136_ValidWord
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("234Adas", true)]
        [TestCase("b3", false)]
        [TestCase("a3$e", false)]
        public void Examples(string word, bool expected)
        {
            var s = new Solution();
            Assert.That(s.IsValid(word), Is.EqualTo(expected));
        }
    }
}
