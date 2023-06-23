from typing import Optional

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"

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
        nodes = ListNode(1, ListNode(2, ListNode(6, ListNode(3, ListNode(4, ListNode(5, ListNode(6)))))))
        solution.removeElements(nodes, 6)

    def test_example3(self):
        solution = Solution()
        nodes = ListNode(7, ListNode(7, ListNode(7, ListNode(7))))
        self.assertEqual(solution.removeElements(nodes, 7), None)

if __name__ == '__main__':
    unittest.main()
