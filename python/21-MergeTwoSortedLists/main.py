from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import ListNode

import unittest


class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if not list1:
            return list2
        
        if not list2:
            return list1
        
        if list1.val < list2.val:
            return ListNode(list1.val, self.mergeTwoLists(list1.next, list2))
        else:
            return ListNode(list2.val, self.mergeTwoLists(list1, list2.next))

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        
        s = solution.mergeTwoLists(ListNode.makeList(1, 2, 4), ListNode.makeList(1, 3, 4))
        values = ListNode.flatten(s)

        self.assertListEqual(values, [1, 1, 2, 3, 4, 4])

if __name__ == '__main__':
    unittest.main()