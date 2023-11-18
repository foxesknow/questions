using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q100_SameTree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q) 
        {
            var stack = new Stack<(TreeNode, TreeNode)>();
            stack.Push((p, q));

            while(stack.TryPop(out var nodes))
            {
                var (left, right) = nodes;

                if(left is null && right is null) continue;
                
                if(left is null || right is null) return false;
                if(left.val != right.val) return false;

                stack.Push((left.left, right.left));
                stack.Push((left.right, right.right));
            }

            return true;
        }
    }
}
