from typing import Optional
from typing import List
import unittest


import sys
sys.path.append('../modules')
from leetcode import ListNode

class Solution:
    def mergeKLists(self, lists: List[Optional[ListNode]]) -> Optional[ListNode]:
        head: Optional[ListNode] = None
        next: Optional[ListNode] = None

        while True:
            index = self.index_of_min_value(lists)
            if index is None:
                break
            
            node = lists[index]

            if head is None:
                head = node
                next = node
            else:
                next.next = node
                next = node

            lists[index] = node.next
            node.next = None            

        return head
    
    def index_of_min_value(self, lists: List[Optional[ListNode]]) -> Optional[int]:        
        min_value = None
        index = None

        for i, l in enumerate(lists):
            if l is None:
                continue
            
            if min_value is None:
                min_value = l.val
                index = i
            else:
                if l.val < min_value:
                    min_value = l.val
                    index = i

        return index
    
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
        n1 = solution.make_list([1,5,9,12])
        n2 = solution.make_list([3,4])
        n = solution.mergeKLists([n1,n2])
        solution.print_node(n)

if __name__ == '__main__':
    unittest.main()