package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func grabNext(list1 *ListNode, list2 *ListNode) (*ListNode, *ListNode, *ListNode) {
	if list1.Val < list2.Val {
		return list1, list1.Next, list2
	} else {
		return list2, list1, list2.Next
	}
}

func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
	if list1 == nil {
		return list2
	}

	if list2 == nil {
		return list1
	}

	next, l1, l2 := grabNext(list1, list2)
	head := next

	for l1 != nil && l2 != nil {
		next.Next, l1, l2 = grabNext(l1, l2)
		next = next.Next
	}

	if l1 != nil {
		next.Next = l1
	} else {
		next.Next = l2
	}

	return head
}

func printList(list *ListNode) {
	for list != nil {
		fmt.Print(list.Val)
		list = list.Next
	}

	fmt.Println()
}

func test1() {
	list1 := &ListNode{Val: 1, Next: &ListNode{Val: 2, Next: &ListNode{Val: 4}}}
	list2 := &ListNode{Val: 1, Next: &ListNode{Val: 3, Next: &ListNode{Val: 4}}}

	printList(mergeTwoLists(list1, list2))
}

func main() {
	test1()
}
