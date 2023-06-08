from typing import Optional
from typing import List
from typing import Tuple

import unittest

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"

class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if k == 1 or head is None:
            return head
        
        group = self.reverse_group(head, head, k)

        if group is None:
            return head
        else:
            group.next = self.reverseKGroup(group.next, k)
            return group
    
    def reverse_group(self, group_head: Optional[ListNode], current: Optional[ListNode], k: int) -> Optional[ListNode]:
        if k ==1 and not current:
            return None

        if k == 1:
            return current

        if not current:
            return None
        
        if not current.next and k != 1:
            return None

        if not current.next:
            return current
        
        new_head = self.reverse_group(group_head, current.next, k - 1)
        if not new_head:
            return None

        current.next.next = current
        current.next = None

        return new_head
        
    
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
        #n = solution.reverseKGroup(nodes, 2)
        n = solution.reverse_group(nodes, nodes, 4)
        solution.print_node(n)

if __name__ == '__main__':
    unittest.main()