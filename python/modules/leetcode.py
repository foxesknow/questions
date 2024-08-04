from typing import Optional, List
from collections import deque

class ListNode:
    def __init__(self, val: int=0, next: Optional['ListNode'] = None):
        self.val = val
        self.next = next

    @staticmethod
    def asNode(node: Optional['ListNode']) -> 'ListNode':
        if node is None:
            raise ValueError('node is None')
        
        return node
    
    @staticmethod
    def makeList(*numbers: int) -> Optional['ListNode']:
        head: Optional[ListNode] = None

        for i in reversed(numbers):
            head = ListNode(i, head)

        return head
    
    @staticmethod
    def flatten(node: Optional['ListNode']) -> List[int]:
        numbers: List[int] = []

        while node is not None:
            numbers.append(node.val)
            node = node.next

        return numbers
    

class TreeNode:
    def __init__(self, val: int=0, left: Optional['TreeNode'] = None, right: Optional['TreeNode'] = None):
        self.val = val
        self.left = left
        self.right = right

    @staticmethod
    def makeTree(root_value: int, *numbers: Optional[int]) -> 'TreeNode':
        root = TreeNode(root_value)
        q = deque[Optional['TreeNode']]()
        q.append(root)

        for i in range(0, len(numbers), 2):
            node = q.popleft()
            
            left_val = numbers[i]
            if left_val and node:
                left_node = TreeNode(left_val)
                node.left = left_node
                q.append(left_node)
            else:
                q.append(None)

            right_val = numbers[i + 1]
            if right_val and node:
                right_node = TreeNode(right_val)
                node.right = right_node
                q.append(right_node)
            else:
                q.append(None)


        return root