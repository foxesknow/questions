from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import ListNode

import unittest


class Solution:
    def removeElements(self, head: Optional[ListNode], val: int) -> Optional[ListNode]:
        while head and head.val == val:
            head = head.next

        if not head:
            return None

        root = head
        while root.next:
            if root.next.val == val:
                root.next = root.next.next
            else:
                root = root.next

        return head

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        nodes = ListNode.makeList(1, 2, 6, 3, 4, 5, 6)
        solution.removeElements(nodes, 6)

    def test_example3(self):
        solution = Solution()
        nodes = ListNode.makeList(7, 7, 7, 7)
        self.assertEqual(solution.removeElements(nodes, 7), None)

if __name__ == '__main__':
    unittest.main()
