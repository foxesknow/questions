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
    public class CountingTrianglesTests
    {
        [Test]
        public void Example1()
        {
            var s = new CountingTriangles();
            var triangles = new List<int[]>
            {
                new[]{2,2,3},
                new[]{3,2,2},
                new[]{2,5,6}
            };

            Assert.That(s.CountDistinct(triangles), Is.EqualTo(2));
        }

        [Test]
        public void Example2()
        {
            var s = new CountingTriangles();
            var triangles = new List<int[]>
            {
                 new[]{8, 4, 6},
                 new[]{100, 101, 102},
                 new[]{84, 93, 173}
            };

            Assert.That(s.CountDistinct(triangles), Is.EqualTo(3));
        }
    }
}
