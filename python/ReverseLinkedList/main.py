from typing import Optional
from typing import List

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

    def __repr__(self):
        return f"{self.val}"

def make_list(numbers: List[int]) -> ListNode:
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

def print_node(node: Optional[ListNode]):
    if not node:
        return
    
    while node:
        print(node.val, " ", end="", sep="")
        node = node.next

    print()


def reverse(node: ListNode) -> ListNode:
    if node.next is None:
        return node
    
    r = reverse(node.next)
    node.next.next = node
    node.next = None

    return r

if __name__ == '__main__':
    node = make_list([1,2,3,4])
    r = reverse(node)
    print_node(r)