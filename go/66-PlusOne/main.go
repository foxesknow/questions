package main

import "fmt"

func plusOne(digits []int) []int {
	result := make([]int, len(digits)+1)

	carry := 1

	for i := len(digits) - 1; i >= 0; i-- {
		total := carry + digits[i]

		result[i+1] = total % 10
		carry = total / 10
	}

	if carry == 0 {
		return result[1:]
	}

	result[0] = carry
	return result
}

func main() {
	fmt.Println(plusOne([]int{1, 2, 3}))
	fmt.Println(plusOne([]int{9, 9}))
}
