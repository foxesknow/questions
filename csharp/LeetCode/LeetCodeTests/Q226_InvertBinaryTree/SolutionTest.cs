using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using LeetCode.Q226_InvertBinaryTree;
using NUnit.Framework;

namespace LeetCodeTests.Q226_InvertBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Example1()
        {
            var s= new Solution();
            var root = new TreeNode
            (
                2,
                new TreeNode(1),
                new TreeNode(3)
            );

            var inverted = s.InvertTree(root);
            Assert.That(inverted.val, Is.EqualTo(2));
            Assert.That(inverted.left.val, Is.EqualTo(3));
            Assert.That(inverted.right.val, Is.EqualTo(1));
        }

        [Test]
        public void Example1_NonRecursive()
        {
            var s= new Solution();
            var root = new TreeNode
            (
                2,
                new TreeNode(1),
                new TreeNode(3)
            );

            var inverted = s.InvertTree_NonRecursive(root);
            Assert.That(inverted.val, Is.EqualTo(2));
            Assert.That(inverted.left.val, Is.EqualTo(3));
            Assert.That(inverted.right.val, Is.EqualTo(1));
        }
    }
}
