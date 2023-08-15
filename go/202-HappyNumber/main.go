package main

import "fmt"

func sumOfSquareDigits(n int) int {
	sum := 0

	for n != 0 {
		digit := n % 10
		sum += (digit * digit)

		n /= 10
	}

	return sum
}

func isHappy(n int) bool {
	seen := make(map[int]bool)

	for n != 1 {
		// If we've alread processed the number then there's
		// a cycle which we need to break out of
		if _, alreadyProcessed := seen[n]; alreadyProcessed {
			break
		}

		seen[n] = true
		n = sumOfSquareDigits(n)
	}

	return n == 1
}

func main() {
	fmt.Println(isHappy(19))
	fmt.Println(isHappy(2))
}
