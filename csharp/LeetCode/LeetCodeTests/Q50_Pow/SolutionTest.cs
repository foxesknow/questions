using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q50_Pow;
using NUnit.Framework;

namespace LeetCodeTests.Q50_Pow
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(2d, 10, 1024d)]
        [TestCase(2.1d, 3, 9.2610d)]
        [TestCase(2d, -2, 0.25d)]
        [TestCase(10d, 0, 1d)]
        [TestCase(10d, 1, 10d)]
        public void Examples(double x, int n, double expected)
        {
            var s = new Solution();
            var result = s.MyPow(x, n);
            Assert.That(result, Is.EqualTo(expected).Within(0.00000001d));
        }
    }
}
