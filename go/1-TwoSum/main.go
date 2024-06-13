package main

import "fmt"

func twoSum(nums []int, target int) []int {
	// We'll map a value to the index we saw it
	indexes := make(map[int]int)

	for i, value := range nums {
		// For any value, the other value we need is target-value
		if existing, found := indexes[target-value]; found {
			return []int{existing, i}
		} else {
			// Remember where we saw the value for later 
			indexes[value] = i
		}
	}

	return []int{}
}

func main() {
	fmt.Println(twoSum([]int{2, 7, 11, 15}, 9))
	fmt.Println(twoSum([]int{3, 2, 4}, 6))
	fmt.Println(twoSum([]int{3, 3}, 6))
}
