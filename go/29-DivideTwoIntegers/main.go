package main

import (
	"fmt"
	"math"
)

const MaxInt int = 2147483647
const MinInt int = -2147483648

func sign(num int) int {
	if num < 0 {
		return -1
	}

	return 1
}

func divide(dividend int, divisor int) int {
	if dividend == MinInt && divisor == -1 {
		return MaxInt
	}

	if dividend == MinInt && divisor == 1 {
		return MinInt
	}

	resultSign := sign(dividend) * sign(divisor)
	dd := int64(math.Abs((float64(dividend))))
	dv := int64(math.Abs((float64(divisor))))

	result := int64(0)

	for dv <= dd {
		var scale int64 = 1
		multiplier := dv

		for multiplier <= (dd - multiplier) {
			multiplier += multiplier
			scale += scale
		}

		result += scale
		dd -= multiplier
	}

	result *= int64(resultSign)

	return int(result)
}

func main() {
	fmt.Println(divide(100, 4))
	fmt.Println(divide(10, 4))
	fmt.Println(divide(10, 3))
}
