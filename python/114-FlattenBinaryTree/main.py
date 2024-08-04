from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import TreeNode

import unittest

class Solution:
    def flatten(self, root: Optional[TreeNode]):
        """
        Do not return anything, modify root in-place instead.
        """

        if not root:
            return None

        head = None
        next = None

        for node in self.pre_order(root):
            if head is None:
                head = node
                next = node
            else:
                next.right = node
                next = next.right


    def pre_order(self, root: Optional[TreeNode]):
        if root:
            left = root.left
            right = root.right

            root.left = None
            root.right = None

            yield root
            if left: yield from self.pre_order(left)
            if right: yield from self.pre_order(right)

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        
        root = TreeNode(1, TreeNode(2), TreeNode(3))
        solution.flatten(root)
        self.assertEqual(root.val, 1)
        self.assertEqual(root.right.val, 2)
        self.assertEqual(root.right.right.val, 3)

    def test_example2(self):
        solution = Solution()
        
        root = TreeNode(1, TreeNode(2, TreeNode(3), TreeNode(4)), TreeNode(5, None, TreeNode(5)))
        solution.flatten(root)
        self.assertEqual(root.val, 1)
        self.assertEqual(root.right.val, 2)
        self.assertEqual(root.right.right.val, 3)
        self.assertEqual(root.right.right.right.val, 4)
        self.assertEqual(root.right.right.right.right.val, 5)
        


if __name__ == '__main__':
    unittest.main()
