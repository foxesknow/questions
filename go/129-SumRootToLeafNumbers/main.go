package main

import "fmt"

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func walk(node *TreeNode, total int, sum int) int {
	total = (total * 10) + node.Val

	if node.Left == nil && node.Right == nil {
		return sum + total
	}

	if node.Left != nil {
		sum = walk(node.Left, total, sum)
	}

	if node.Right != nil {
		sum = walk(node.Right, total, sum)
	}

	return sum
}

func sumNumbers(root *TreeNode) int {
	return walk(root, 0, 0)
}

func test1() int {
	tree := &TreeNode{Val: 1, Left: &TreeNode{Val: 2}, Right: &TreeNode{Val: 3}}
	return sumNumbers(tree)
}

func test2() int {
	tree := &TreeNode{
		Val: 4,
		Left: &TreeNode{
			Val:   9,
			Left:  &TreeNode{Val: 5},
			Right: &TreeNode{Val: 1},
		},
		Right: &TreeNode{Val: 0},
	}
	return sumNumbers(tree)
}

func test3() int {
	tree := &TreeNode{
		Val:  1,
		Left: &TreeNode{Val: 5},
		Right: &TreeNode{
			Val:   1,
			Right: &TreeNode{Val: 6},
		},
	}
	return sumNumbers(tree)
}

func main() {
	fmt.Println(test1())
	fmt.Println(test2())
	fmt.Println(test3())
}
