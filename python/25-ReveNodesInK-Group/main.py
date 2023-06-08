from typing import Optional
from typing import List

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
        nodes = solution.make_list([1,2,3,4,5,6])
        solution.print_node(solution.reverseKGroup(nodes, 2))

    def test_example1(self):
        solution = Solution()
        nodes = solution.make_list([1,2,3,4,5])
        solution.print_node(solution.reverseKGroup(nodes, 3))



if __name__ == '__main__':
    unittest.main()