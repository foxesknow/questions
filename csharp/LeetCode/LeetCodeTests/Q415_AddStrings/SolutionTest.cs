using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q415_AddStrings;
using NUnit.Framework;

namespace LeetCodeTests.Q415_AddStrings
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("11", "123", "134")]
        [TestCase("1", "12345", "12346")]
        public void Examples(string num1, string num2, string expected)
        {
            var s = new Solution();
            Assert.That(s.AddStrings(num1, num2), Is.EqualTo(expected));
        }
    }
}
