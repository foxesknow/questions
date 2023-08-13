package main

import "fmt"

func myPow(x float64, n int) float64 {
	switch {
	case x == 1 || n == 0:
		return 1

	case n == 1:
		return x

	case n == -1:
		return 1 / x

	case x == 0:
		return 0
	}

	half := myPow(x, n/2)
	result := half * half

	if n&1 == 1 {
		sign := 1

		if n < 0 {
			sign = -1
		}

		return result * myPow(x, sign)
	} else {
		return result
	}
}

func main() {
	fmt.Println(myPow(2.0, 10))
	fmt.Println(myPow(2.1, 3))
	fmt.Println(myPow(2.0, -2))
	fmt.Println(myPow(2.0, 10))
}
