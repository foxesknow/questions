from typing import Optional, Self

import unittest

import sys
sys.path.append('../modules')
from leetcode import TreeNode

class Solution:
    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        if root:
            tmp = root.left
            root.left = root.right
            root.right = tmp

            self.invertTree(root.left)
            self.invertTree(root.right)

        return root
    
    def invertTree_stack(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        if root:
            stack = [root]
            while len(stack):
                next = stack.pop()

                tmp = next.left
                next.left = next.right
                next.right = tmp

                if next.left: stack.append(next.left)
                if next.right: stack.append(next.right)

        return root
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()

        tree = TreeNode(2, TreeNode(1), TreeNode(3))
        new_tree = solution.invertTree(tree)
        self.assertIsNotNone(new_tree)


if __name__ == '__main__':
    unittest.main()
