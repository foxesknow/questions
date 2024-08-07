from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import TreeNode

import unittest

class Solution:
    def hasPathSum(self, root: Optional[TreeNode], targetSum: int) -> bool:
        if root is None:
            return False

        # We're at a leaf node
        if root.left is None and root.right is None and targetSum - root.val == 0:
            return True

        if root.left and self.hasPathSum(root.left, targetSum - root.val) :
            return True

        if root.right and self.hasPathSum(root.right, targetSum - root.val) :
            return True

        return False

    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        
        root = TreeNode.makeTree(1, 2, 3)
        self.assertTrue(solution.hasPathSum(root, 3))

    def test_example2(self):
        solution = Solution()
        
        root = TreeNode.makeTree(1, 2, 3)
        self.assertTrue(solution.hasPathSum(root, 4))

    def test_example3(self):
        solution = Solution()
        
        root = None
        self.assertFalse(solution.hasPathSum(root, 0))

    def test_example4(self):
        solution = Solution()
        
        root = TreeNode.makeTree(5, 4, 8, 11, None, 13, 4, 7, 2, None, None, None, 1)
        self.assertTrue(solution.hasPathSum(root, 22))


if __name__ == '__main__':
    unittest.main()
