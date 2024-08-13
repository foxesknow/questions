from typing import Optional

import sys
sys.path.append('../modules')
from leetcode import ListNode

import unittest

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        return self.do_add(l1, l2, 0)
    
    def do_add(self, l1: Optional[ListNode], l2: Optional[ListNode], carry: int) -> Optional[ListNode]:
        
        if l1 is None and l2 is None and carry == 0:
            return None
        
        sum = carry
        if l1: sum += l1.val
        if l2: sum += l2.val

        newNode = ListNode(sum % 10)

        l1_next = l1.next if l1 else None
        l2_next = l2.next if l2 else None
        newNode.next = self.do_add(l1_next, l2_next, sum // 10)

        return newNode
    

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()

        l1 = ListNode.makeList(2, 4, 3);
        l2 = ListNode.makeList(5, 6, 4);

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)

        values = ListNode.flatten(result)
        self.assertTrue(len(values) == 3)
        self.assertTrue(values[0] == 7)
        self.assertTrue(values[1] == 0)
        self.assertTrue(values[2] == 8)

    def test_example2(self):
        solution = Solution()

        l1 = ListNode(0)
        l2 = ListNode(0)

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)

        values = ListNode.flatten(result)
        self.assertTrue(len(values) == 1)

        self.assertTrue(values[0] == 0)

    def test_example3(self):
        solution = Solution()

        l1 = ListNode(9, ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9))))))) 
        l2 =  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9))))

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)

        values = ListNode.flatten(result)
        self.assertTrue(len(values) == 8)

        self.assertListEqual(values, [8, 9, 9, 9, 0, 0, 0, 1]);

        



if __name__ == '__main__':
    unittest.main()