from typing import Optional

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head:
            return None

        new_head = head
        next = head.next
        new_head.next = None

        while next:
            temp = next.next
            next.next = new_head
            new_head = next
            next = temp

        return new_head

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        nodes = ListNode(1, ListNode(2, ListNode(3, ListNode(4, ListNode(5,)))))
        solution.reverseList(nodes)


if __name__ == '__main__':
    unittest.main()
