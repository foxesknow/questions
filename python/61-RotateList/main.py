from typing import Optional
from typing import Tuple

import unittest

import sys
sys.path.append('../modules')
from leetcode import ListNode


class Solution:
    def rotateRight(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if k == 0:
            return head

        (length, tail) = self.length_and_tail(head)
        if length == 0 or length == 1:
                return head
        
        # k can be larger than the length of the list so we should work
        # out how much we actually do heed to shift by
        shift = k % length
        if shift == 0:
            return head

        to_skip = length - shift

        new_head = head
        previous = None

        while to_skip != 0:
             previous = new_head
             new_head = new_head.next
             to_skip -= 1

        previous.next = None
        tail.next = head

        return new_head
        
    
    def length_and_tail(self, head: Optional[ListNode]) -> Tuple[int, Optional[ListNode]]:
        count = 0
        tail = None

        while head is not None:
            count += 1
            tail = head
            head = head.next

        return (count, tail)
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        l = ListNode.makeList(0, 1, 2)
        result = solution.rotateRight(l, 1)
        self.assertListEqual(ListNode.flatten(result), [2, 0, 1])

    def test_example2(self):
        solution = Solution()
        l = ListNode(0, ListNode(1, ListNode(2)))
        solution.rotateRight(l, 6)

    def test_example3(self):
        solution = Solution()
        l = ListNode(1)
        solution.rotateRight(l, 1)

    def test_example4(self):
        solution = Solution()
        l = ListNode(1)
        solution.rotateRight(l, 99)


if __name__ == '__main__':
    unittest.main()