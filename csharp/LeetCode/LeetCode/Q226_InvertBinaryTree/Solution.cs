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
    }
}
