package main

import "fmt"

type Node struct {
	Val      int
	Children []*Node
}

func preorder(root *Node) []int {
	values := make([]int, 0)

	if root == nil {
		return values
	}

	var stack []*Node
	stack = append(stack, root)

	for len(stack) != 0 {
		length := len(stack)
		top := stack[length-1]
		stack = stack[0 : length-1]

		values = append(values, top.Val)

		for i := len(top.Children) - 1; i >= 0; i-- {
			child := top.Children[i]
			stack = append(stack, child)
		}
	}

	return values
}

func test3() {
	node := &Node{Val: 1, Children: nil}
	fmt.Println(preorder(node))
}

func main() {
	test3()
}
