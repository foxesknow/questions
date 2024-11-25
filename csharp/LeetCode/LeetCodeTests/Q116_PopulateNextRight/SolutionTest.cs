using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode.Q116_PopulateNextRight;

using NUnit.Framework;

namespace LeetCodeTests.Q116_PopulateNextRight
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            Node root = new
            (
                1,
                new
                (
                    2,
                    new(4),
                    new(5),
                    null
                ),
                new
                (
                    3,
                    new(6),
                    new(7),
                    null
                ),
                null
            );

            var s = new Solution();
            var node = s.Connect(root);
        }

        [Test]
        public void Example2()
        {
            var s = new Solution();
            Assert.That(s.Connect(null), Is.Null);
        }
    }
}
