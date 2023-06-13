from typing import Optional

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"

class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head or not head.next:
            return head
        
        return self.walk(head, head.next)


    def walk(self, head: Optional[ListNode], next: Optional[ListNode]) -> Optional[ListNode]:
        if not next:
            return None

        if head.val < next.val:
            head.next = next
            self.walk(next, next.next)
            return head
        else:
            head.next = next.next
            self.walk(head, head.next)
            return head

        

class Tests(unittest.TestCase):
    def test_example0(self):
        solution = Solution()
        list = ListNode(1, ListNode(1))
        normalized = solution.deleteDuplicates(list)
        self.assertIsNotNone(normalized)

    def test_example1(self):
        solution = Solution()
        list = ListNode(1, ListNode(1, ListNode(2)))
        normalized = solution.deleteDuplicates(list)
        self.assertIsNotNone(normalized)

    def test_example2(self):
        solution = Solution()
        list = ListNode(1, ListNode(1, ListNode(2, ListNode(3, ListNode(3)))))
        normalized = solution.deleteDuplicates(list)
        self.assertIsNotNone(normalized)

    def test_example3(self):
        solution = Solution()
        list = ListNode(1, ListNode(2))
        normalized = solution.deleteDuplicates(list)
        self.assertIsNotNone(normalized)

if __name__ == '__main__':
    unittest.main()