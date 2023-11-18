using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeetCode;
using LeetCode.Q100_SameTree;

using NUnit.Framework;

namespace LeetCodeTests.Q100_SameTree
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Example1()
        {
            var left = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var right = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            
            var solution = new Solution();
            Assert.That(solution.IsSameTree(left, right), Is.True);
        }

        [Test]
        public void Example2()
        {
            var left = new TreeNode(1, new TreeNode(2), null);
            var right = new TreeNode(1, null, new TreeNode(2));
            
            var solution = new Solution();
            Assert.That(solution.IsSameTree(left, right), Is.False);
        }

        [Test]
        public void Example3()
        {
            var left = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            var right = new TreeNode(1, new TreeNode(1), new TreeNode(2));
            
            var solution = new Solution();
            Assert.That(solution.IsSameTree(left, right), Is.False);
        }

        [Test]
        public void Example4()
        {
            var left = new TreeNode(1, new TreeNode(2), null);
            var right = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            
            var solution = new Solution();
            Assert.That(solution.IsSameTree(left, right), Is.False);
        }
    }
}
