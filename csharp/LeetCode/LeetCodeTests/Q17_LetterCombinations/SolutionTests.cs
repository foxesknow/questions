using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Q17_LetterCombinations;

using NUnit.Framework;

namespace LeetCodeTests.Q17_LetterCombinations
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var s = new Solution();
            var letters = s.LetterCombinations("23");
            Assert.That(letters, Is.Not.Null);
        }
    }
}
