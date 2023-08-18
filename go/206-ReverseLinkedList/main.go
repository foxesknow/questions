package main

type ListNode struct {
	Val  int
	Next *ListNode
}

func reverseList(head *ListNode) *ListNode {
	if head == nil {
		return head
	}

	var newHead *ListNode = nil

	for head != nil {
		after := head.Next
		head.Next = newHead
		newHead = head
		head = after
	}

	return newHead
}

func main() {
	list := &ListNode{Val: 1, Next: &ListNode{Val: 2, Next: &ListNode{Val: 3}}}
	reverseList(list)
}
