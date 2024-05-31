package main

import (
	"fmt"
	"math"
)

func isDigit(c rune) bool {
	return c >= '0' && c <= '9'
}

func toNumber(c rune) int {
	return int(c - '0')
}

func skipWhitespace(s []rune) []rune {
	for i, c := range s {
		if c != ' ' {
			return s[i:]
		}
	}

	return nil
}

func myAtoi(s string) int {
	runes := skipWhitespace([]rune(s))

	if len(runes) == 0 {
		return 0
	}

	isNegative := false
	if runes[0] == '-' || runes[0] == '+' {
		isNegative = runes[0] == '-'
		runes = runes[1:]
	}

	var number int64 = 0

	for i := 0; i < len(runes) && isDigit(runes[i]); i++ {
		number = (number * 10) + int64(toNumber(runes[i]))

		if number > math.MaxInt32 {
			break
		}
	}

	if isNegative {
		number *= -1
	}

	if number > math.MaxInt32 {
		number = math.MaxInt32
	} else if number < math.MinInt32 {
		number = math.MinInt32
	}

	return int(number)
}

func test1() {
	fmt.Println(myAtoi("42"))
}

func test2() {
	fmt.Println(myAtoi("-042"))
}

func test3() {
	fmt.Println(myAtoi("1337c0d3"))
}

func test4() {
	fmt.Println(myAtoi("0-1"))
}

func test5() {
	fmt.Println(myAtoi("words and 987"))
}

func test6() {
	fmt.Println(myAtoi("2147483647"))
}

func test7() {
	fmt.Println(myAtoi("2147483649"))
}

func main() {
	test1()
	test2()
	test3()
	test4()
	test5()
	test6()
	test7()
}
