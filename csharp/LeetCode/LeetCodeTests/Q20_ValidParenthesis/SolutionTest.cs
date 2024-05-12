using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q20_ValidParenthesis;
using NUnit.Framework;

namespace LeetCodeTests.Q20_ValidParenthesis
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(}", false)]
        [TestCase("(", false)]
        [TestCase("([{}])", true)]
        public void Example(string expression, bool expected)
        {
            var s = new Solution();
            Assert.That(s.IsValid(expression), Is.EqualTo(expected));
        }
    }
}
