from typing import Optional
import unittest

import sys
sys.path.append('../modules')
from leetcode import ListNode


class Solution:
    def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None or head.next is None or head.next.next is None:
            return head

        odd = head
        base_even = even = head.next

        while odd or even:
            next_odd = odd and (odd.next or None) and (odd.next.next);
            next_even = even and (even.next or None) and (even.next.next);

            if next_odd:
                odd.next = next_odd
            else:
                odd.next = base_even
            
            if even: 
                even.next = next_even
                
            odd = next_odd
            even = next_even

        return head

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        nodes = ListNode.makeList(1, 2, 3, 4, 5)
        result = solution.oddEvenList(nodes)
        values = ListNode.flatten(result)
        self.assertListEqual(values, [1, 3, 5, 2, 4])

    def test_example2(self):
        solution = Solution()
        nodes = ListNode.makeList(2, 1, 3, 5, 6, 4, 7)
        result = solution.oddEvenList(nodes)
        values = ListNode.flatten(result)
        self.assertListEqual(values, [2, 3, 6, 7, 1, 5, 4])

if __name__ == '__main__':
    unittest.main()