from typing import Optional
import unittest

import sys
sys.path.append('../modules')
from leetcode import ListNode

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
        s = solution.swapPairs(ListNode.makeList(1, 2, 3, 4))
        
        values = ListNode.flatten(s)
        self.assertListEqual(values, [2, 1, 4, 3]);

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