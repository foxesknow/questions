package main

import "fmt"

func intAbs(x int) int {
	if x < 0 {
		return 0 - x
	}

	return x
}

func reverse(x int) int {
	const maxInt = 2147483647

	isNegative := (x < 0)
	value := 0

	for x != 0 {
		nextDigit := intAbs(x % 10)

		// Check for overflow
		if value != 0 && ((maxInt-nextDigit)/value) < 10 {
			return 0
		}

		value = (value * 10) + nextDigit
		x /= 10
	}

	if isNegative {
		value *= -1
	}

	return value

}

func main() {
	fmt.Println(reverse(123))
	fmt.Println(reverse(-123))
	fmt.Println(reverse(120))
}
