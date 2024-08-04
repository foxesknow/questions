from typing import Optional
from typing import List
from typing import Tuple

import unittest

import sys
sys.path.append('../modules')
from leetcode import ListNode


class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if k == 1 or head is None:
            return head
        
        # First up sort the group starting at head
        # For a list 1 2 3 4 5 6 and k = 3 this means that
        # group point to 3 2 1 and rest will point to 4 5 6
        # If the group is smaller than k then group will be null
        (group, rest) = self.reverse_group(head, head, k)

        if group is None:
            # We couldn't sort the group, so head points to our
            # unsuorted group
            return head
        else:
            # What was the head is now at the tail of the list.
            # We now sort "rest" and add it to the list
            head.next = self.reverseKGroup(rest, k)
            return group
    
    def reverse_group(self, group_head: Optional[ListNode], current: Optional[ListNode], k: int) -> Tuple[Optional[ListNode], Optional[ListNode]]:
        # We're at the end of the group
        if k == 1 and current:
            return (current, current.next)

        # We're not at the end of the group, but there isn't another item.
        # This means the group is smaller than k and shouldn't be sorted        
        if k != 1 and not current.next:
            return (None, None)
        
        (new_head, rest) = self.reverse_group(group_head, current.next, k - 1)
        if not new_head:
            # A new_head of none means the group can be reversed
            return (None, rest)

        current.next.next = current
        current.next = None

        return (new_head, rest)
        
    
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
        nodes = solution.make_list([1,2,3,4])
        n = solution.reverseKGroup(nodes, 5)
        #(n, rest) = solution.reverse_group(nodes, nodes, 2)
        solution.print_node(n)

if __name__ == '__main__':
    unittest.main()