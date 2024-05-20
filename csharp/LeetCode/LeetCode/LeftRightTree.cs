using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeftRightTree
    {
        /// <summary>
        /// We need to return the left view of the tree, bottom to top,
        /// and the right view of the  tree, top to bottom.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int[] GenerateView(TreeNode root)
        {
            var left = root;
            var right = root;

            var leftAnswer = new List<int>();
            var rightAnswer = new List<int>();

            while(left is not null && right is not null)
            {
                leftAnswer.Insert(0, left.val);
                rightAnswer.Add(right.val);

                // Now move down a level (if possible);
                left = left.left ?? left.right;
                right = right.right ?? right.left;

                // And now handle the case where there 0 or 1 items at the next level
                if(left is null) left = right;
                if(right is null) right = left;
            }

            return leftAnswer.Concat(rightAnswer.Skip(1)).ToArray();
        }
    }
}
