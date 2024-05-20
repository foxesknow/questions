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
    public class LeftRightTreeTests
    {
        [Test]
        public void Example1()
        {
            var s = new LeftRightTree();

            var tree = new TreeNode(1, new(2), new(3));
            var result = s.GenerateView(tree);
            Assert.That(result, Is.EqualTo(new int[]{2, 1, 3}));
        }

        [Test]
        public void Example2()
        {
            var s = new LeftRightTree();

            var tree = new TreeNode(1, new(2, new(3, new(4))));
            var result = s.GenerateView(tree);
            Assert.That(result, Is.EqualTo(new int[]{4, 3, 2, 1, 2, 3, 4}));
        }

        [Test]
        public void Example3()
        {
            var s = new LeftRightTree();

            var tree = new TreeNode(1, new(2, new(3, new(4), new (5))));
            var result = s.GenerateView(tree);
            Assert.That(result, Is.EqualTo(new int[]{4, 3, 2, 1, 2, 3, 5}));
        }
    }
}
