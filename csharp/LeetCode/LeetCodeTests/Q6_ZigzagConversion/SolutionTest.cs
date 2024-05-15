using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q6_ZigzagConversion;
using NUnit.Framework;

namespace LeetCodeTests.Q6_ZigzagConversion
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [TestCase("A", 1, "A")]
        [TestCase("AB", 1, "AB")]
        public void Examples(string input, int numRows, string expected)
        {
            var s = new Solution();
            var zig = s.Convert(input, numRows);
            Assert.That(zig, Is.EqualTo(expected));
        }
    }
}
