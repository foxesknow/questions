package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeKLists(lists []*ListNode) *ListNode {
	var head *ListNode = nil
	var tail *ListNode = nil

	for i, n := next(lists); n != nil; i, n = next(lists) {
		lists[i] = lists[i].Next

		if head == nil {
			head = n
			tail = n
			n.Next = nil
		} else {
			tail.Next = n
			tail = n
			tail.Next = nil
		}
	}
	return head
}

func next(lists []*ListNode) (int, *ListNode) {
	var node *ListNode = nil
	index := -1

	for i, n := range lists {
		if n == nil {
			continue
		}

		if node == nil {
			node = n
			index = i
			continue
		}

		if n.Val < node.Val {
			node = n
			index = i
		}
	}

	return index, node
}

func printList(list *ListNode) {
	for list != nil {
		fmt.Print(list.Val)
		list = list.Next
	}

	fmt.Println()
}

func example1() {
	l1 := &ListNode{Val: 1, Next: &ListNode{Val: 4, Next: &ListNode{Val: 5}}}
	l2 := &ListNode{Val: 1, Next: &ListNode{Val: 3, Next: &ListNode{Val: 4}}}
	l3 := &ListNode{Val: 2, Next: &ListNode{Val: 6}}

	result := mergeKLists([]*ListNode{l1, l2, l3})
	printList(result)
}

func main() {
	example1()
}
