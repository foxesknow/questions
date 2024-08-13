package main

import (
	"fmt"
	"slices"
)

func threeSum(nums []int) [][]int {
	slices.Sort(nums)

	var lastIndex = len(nums) - 1
	numbers := make([][]int, 0)

	for i := 0; i < len(nums); i++ {
		first := nums[i]
		if first > 0 {
			break
		}

		// It's the same number as last time, so don't bother
		if i > 0 && first == nums[i-1] {
			continue
		}

		// If the first 2 numbers take as over 0 then we're done
		if i != lastIndex && first+nums[i+1] > 0 {
			break
		}

		left := i + 1
		right := lastIndex

		for left < right {
			second := nums[left]

			// If we're above zero then no need to carry on
			if first+second > 0 {
				break
			}

			third := nums[right]
			sum := first + second + third

			if sum == 0 {
				numbers = append(numbers, []int{first, second, third})

				// We need to move to the next numbers that are't the same as
				// the ones we're currently looking at
				for left < right && second == nums[left] {
					left++
				}

				for right > left && third == nums[right] {
					right--
				}
			} else if sum < 0 {
				left++
			} else {
				right--
			}
		}
	}

	return numbers
}

func test1() {
	result := threeSum([]int{-1, 0, 1, 2, -1, -4})
	fmt.Println(result)
}

func test2() {
	result := threeSum([]int{0, -1, -1})
	fmt.Println(result)
}

func test3() {
	result := threeSum([]int{0, 0, 0})
	fmt.Println(result)
}

func test4() {
	result := threeSum([]int{1, 2, -2, -1})
	fmt.Println(result)
}

func main() {
	test1()
	test2()
	test3()
	test4()
}
