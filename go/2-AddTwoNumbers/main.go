package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	carry := 0

	var head *ListNode = nil
	var next *ListNode = nil

	for l1 != nil || l2 != nil || carry != 0 {
		sum := carry

		if l1 != nil {
			sum += l1.Val
			l1 = l1.Next
		}

		if l2 != nil {
			sum += l2.Val
			l2 = l2.Next
		}

		node := &ListNode{Val: sum % 10}
		carry = sum / 10

		if next != nil {
			next.Next = node
			next = node
		} else {
			head = node
			next = node
		}
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
	l1 := &ListNode{Val: 2, Next: &ListNode{Val: 4, Next: &ListNode{Val: 3}}}
	l2 := &ListNode{Val: 5, Next: &ListNode{Val: 6, Next: &ListNode{Val: 4}}}
	printList(addTwoNumbers(l1, l2))
}

func test2() {
	l1 := &ListNode{Val: 0}
	l2 := &ListNode{Val: 0}
	printList(addTwoNumbers(l1, l2))
}

func main() {
	test1()
	test2()
}
