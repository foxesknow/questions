from typing import Optional
from typing import Iterator
from typing import Self

import unittest

class TreeNode:
    def __init__(self, val: int=0, left: Optional[Self] = None, right: Optional[Self] = None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        for value in self.walk_bst(root):
            k -= 1
            if k == 0:
                return value

        return 0
    
    def walk_bst(self, root: Optional[TreeNode]) -> Iterator[int]:
        if not root:
            return
        
        yield from self.walk_bst(root.left)
        yield root.val
        yield from self.walk_bst(root.right)


class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()

        tree = TreeNode(3, TreeNode(1, None, TreeNode(2)), TreeNode(4))
        self.assertEqual(solution.kthSmallest(tree, 1), 1)
        self.assertEqual(solution.kthSmallest(tree, 2), 2)
        self.assertEqual(solution.kthSmallest(tree, 3), 3)
        self.assertEqual(solution.kthSmallest(tree, 4), 4)


if __name__ == '__main__':
    unittest.main()
