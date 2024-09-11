using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q226_InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root) 
        {
            if(root is null) return root;

            var newLeft = InvertTree(root.right);
            var newRight = InvertTree(root.left);

            root.left = newLeft;
            root.right = newRight;

            return root;
        }

        public TreeNode InvertTree_NonRecursive(TreeNode root) 
        {
            if(root is null) return root;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.TryPop(out var node))
            {
                (node.left, node.right) = (node.right, node.left);

                if(node.left is not null) stack.Push(node.left);
                if(node.right is not null) stack.Push(node.right);
            }

            return root;
        }
    }
}
