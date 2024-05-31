package main

import "fmt"

func removeElement(nums []int, val int) int {
	count := 0
	front := 0

	for i, n := range nums {
		if n != val {
			nums[i], nums[front] = nums[front], nums[i]
			front++
			count++
		}
	}

	return count
}

func example1() {
	nums := []int{3, 2, 2, 3}
	count := removeElement(nums, 3)
	fmt.Printf("%d = %v\n", count, nums)
}

func example2() {
	nums := []int{0, 1, 2, 2, 3, 0, 4, 2}
	count := removeElement(nums, 2)
	fmt.Printf("%d = %v\n", count, nums)
}

func main() {
	example1()
	example2()
}
