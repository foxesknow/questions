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
    public class EncryptedWordsTests
    {
        [Test]
        [TestCase("abc", "bac")]
        [TestCase("abcd", "bacd")]
        [TestCase("abcxcba", "xbacbca")]
        [TestCase("facebook", "eafcobok")]
        public void Example1(string text, string expected)
        {
            var s = new EncryptedWords();
            var result = s.Encrypt(text);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
