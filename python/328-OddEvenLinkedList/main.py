from typing import Optional
import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"


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
        nodes = ListNode(1, ListNode(2, ListNode(3, ListNode(4, ListNode(5)))))
        solution.oddEvenList(nodes)

    def test_example2(self):
        solution = Solution()
        nodes = ListNode(2, ListNode(1, ListNode(3, ListNode(5, ListNode(6, ListNode(4, ListNode(7)))))))
        solution.oddEvenList(nodes)

if __name__ == '__main__':
    unittest.main()