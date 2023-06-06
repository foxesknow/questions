from typing import List
from typing import Optional

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


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

        l1 = ListNode(2, ListNode(4, ListNode(3)))
        l2 = ListNode(5, ListNode(6, ListNode(4)))

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)
        self.assertTrue(result.val == 7)
        self.assertTrue(result.next.val == 0)
        self.assertTrue(result.next.next.val == 8)
        self.assertIsNone(result.next.next.next);

    def test_example2(self):
        solution = Solution()

        l1 = ListNode(0)
        l2 = ListNode(0)

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)
        self.assertTrue(result.val == 0)
        self.assertIsNone(result.next);

    def test_example3(self):
        solution = Solution()

        l1 = ListNode(9, ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9))))))) 
        l2 =  ListNode(9,  ListNode(9,  ListNode(9,  ListNode(9))))

        result = solution.addTwoNumbers(l1, l2)
        self.assertIsNotNone(result)
        self.assertTrue(result.val == 8)
        self.assertTrue(result.next.val == 9)
        self.assertTrue(result.next.next.val == 9)
        self.assertTrue(result.next.next.next.val == 9)
        self.assertTrue(result.next.next.next.next.val == 0)
        self.assertTrue(result.next.next.next.next.next.val == 0)
        self.assertTrue(result.next.next.next.next.next.next.val == 0)
        self.assertTrue(result.next.next.next.next.next.next.next.val == 1)
        self.assertIsNone(result.next.next.next.next.next.next.next.next)
        



if __name__ == '__main__':
    unittest.main()