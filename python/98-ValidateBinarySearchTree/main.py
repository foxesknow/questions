from typing import Optional

import unittest

import sys
sys.path.append('../modules')
from leetcode import TreeNode

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        if not root:
            return True
        
        last: Optional[int] = None
        for val in self.in_order(root):
            if last is not None:
                if last >= val:
                    return False
                
            last = val

        return True

    
    def in_order(self, root: Optional[TreeNode]):
        if root:
            yield from self.in_order(root.left)
            yield int(root.val)
            yield from self.in_order(root.right)
        
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        
        root = TreeNode(2, TreeNode(1), TreeNode(3))
        self.assertTrue(solution.isValidBST(root))

    def test_example2(self):
        solution = Solution()
        
        root = TreeNode(5, TreeNode(1), TreeNode(4, TreeNode(3), TreeNode(6)))
        self.assertFalse(solution.isValidBST(root))

    def test_example3(self):
        solution = Solution()
        
        root = TreeNode(2, TreeNode(2), TreeNode(2))
        self.assertFalse(solution.isValidBST(root))

    def test_example4(self):
        solution = Solution()
        
        root = TreeNode(0, None, TreeNode(-1))

        self.assertFalse(solution.isValidBST(root))

if __name__ == '__main__':
    unittest.main()