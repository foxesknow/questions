from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import ListNode

import unittest

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
        nodes = ListNode.makeList(1, 2, 3, 4, 5)
        reversed = solution.reverseList(nodes)
        values = ListNode.flatten(reversed);

        self.assertListEqual(values, [5, 4, 3, 2, 1])


if __name__ == '__main__':
    unittest.main()
