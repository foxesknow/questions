from typing import Optional
from typing import List
from typing import Tuple

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if k == 1 or head is None:
            return head
        
        block: List[ListNode] = []

        next = head
        for i in range(k):
            block.append(next)
            next = next.next

            if next is None:
                break
            
        if len(block) != k:
            return head
        
        for i in range(1, k):
            block[i].next = block[i - 1]

        block[0].next = self.reverseKGroup(next, k)

        return block[-1]
    
    def reverse_group(self, head: Optional[ListNode], k: int) -> Tuple[Optional[ListNode], Optional[ListNode]]:
        next = None if head is None else head.next

        if k == 0:
            return (head, next)
        
        (x, rest) = self.reverse_group(head.next, k - 1)
        if rest is None:
            return (head, None)
        
        head.next = self.reverse_group(rest, k)
        return (x, rest)
        
    
    def make_list(self, numbers: List[int]) -> ListNode:
        if len(numbers) == 0:
            return None
        
        head: ListNode = None
        next: ListNode = None

        for num in numbers:
            if next:
                node = ListNode(num)
                next.next = node
                next = node
            else:
                head = ListNode(num)
                next = head

        return head
    
    def print_node(self, node: ListNode):
        if not node:
            return
        
        while node:
            print(node.val, " ", end="", sep="")
            node = node.next

        print()
            
        
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        nodes = solution.make_list([1,2,3])
        (n, rest) = solution.reverse_group(nodes, 2)
        solution.print_node(n)

if __name__ == '__main__':
    unittest.main()