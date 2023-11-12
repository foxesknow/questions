package main

type ListNode struct {
	Val  int
	Next *ListNode
}

func getIntersectionNode(headA, headB *ListNode) *ListNode {
	lookup := make(map[*ListNode]bool)

	for node := headA; node != nil; node = node.Next {
		lookup[node] = true
	}

	for node := headB; node != nil; node = node.Next {
		_, found := lookup[node]

		if found {
			return node
		}
	}

	return nil
}

func main() {
}
