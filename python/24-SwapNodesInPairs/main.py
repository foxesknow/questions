from typing import Optional
import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def swapPairs(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head:
            return head
        
        second = head.next
        if not second:
            return head
        
        rest = second.next

        second.next = head
        head.next = self.swapPairs(rest)

        return second
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        s = solution.swapPairs(ListNode(1, ListNode(2, ListNode(3, ListNode(4)))))
        self.assertTrue(s.val == 2)
        self.assertTrue(s.next.val == 1)
        self.assertTrue(s.next.next.val == 4)
        self.assertTrue(s.next.next.next.val == 3)
        self.assertIsNone(s.next.next.next.next)

    def test_example2(self):
        solution = Solution()
        s = solution.swapPairs(None)
        self.assertIsNone(s)

    def test_example3(self):
        solution = Solution()
        s = solution.swapPairs(ListNode(1))
        self.assertTrue(s.val == 1)
        self.assertIsNone(s.next)

if __name__ == '__main__':
    unittest.main()