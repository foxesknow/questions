from typing import Optional
from typing import List

import sys
sys.path.append('../modules')
from leetcode import TreeNode

import unittest

class Solution:
    def pathSum(self, root: Optional[TreeNode], targetSum: int) -> List[List[int]]:
        result: List[List[int]] = []
        self.walk(root, targetSum, [], result)

        return result

    def walk(self, root: Optional[TreeNode], targetSum: int, path: List[int], acc: List[List[int]]):
        if root is None:
            return

        path.append(root.val)

        try:
            # We're at a leaf node
            if root.left is None and root.right is None and targetSum - root.val == 0:
                clone = path.copy()
                acc.append(clone)

            if root.left:
                self.walk(root.left, targetSum - root.val, path, acc)

            if root.right:
                self.walk(root.right, targetSum - root.val, path, acc)
        finally:
            path.pop(len(path) - 1)

    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        
        root = TreeNode(1, TreeNode(2), TreeNode(3))
        paths = solution.pathSum(root, 3)
        print(paths)

    def test_example1(self):
        solution = Solution()
        
        root = TreeNode(1, TreeNode(2), TreeNode(1, TreeNode(1)))
        paths = solution.pathSum(root, 3)
        print(paths)


if __name__ == '__main__':
    unittest.main()
