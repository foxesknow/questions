package main

import (
	"fmt"
	"strconv"
)

func evalRPN(tokens []string) int {
	stack := make([]int, 0, len(tokens))

	push := func(value int) {
		stack = append(stack, value)
	}

	pop := func() int {
		length := len(stack)
		value := stack[length-1]
		stack = stack[:length-1]

		return value
	}

	for _, token := range tokens {
		switch token {
		case "+":
			rhs := pop()
			lhs := pop()
			push(lhs + rhs)

		case "-":
			rhs := pop()
			lhs := pop()
			push(lhs - rhs)

		case "*":
			rhs := pop()
			lhs := pop()
			push(lhs * rhs)

		case "/":
			rhs := pop()
			lhs := pop()
			push(lhs / rhs)

		default:
			value, _ := strconv.Atoi(token)
			push(value)
		}
	}

	return stack[0]
}

func main() {
	fmt.Println(evalRPN([]string{"2", "1", "+", "3", "*"}))
	fmt.Println(evalRPN([]string{"4", "13", "5", "/", "+"}))
	fmt.Println(evalRPN([]string{"1", "10", "100", "+", "+"}))
}
