from typing import Optional, List


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