package main

import (
	"fmt"
	"strings"
)

func subtractRepeatidly(num int, substract int, romanDigit string, existing *strings.Builder) int {
	for num >= substract {
		existing.WriteString(romanDigit)
		num -= substract
	}

	return num
}

func subtractOnce(num int, substract int, romanDigit string, existing *strings.Builder) int {
	if num >= substract {
		existing.WriteString(romanDigit)
		num -= substract
	}

	return num
}

func intToRoman(num int) string {
	var roman strings.Builder

	num = subtractRepeatidly(num, 1000, "M", &roman)
	num = subtractOnce(num, 900, "CM", &roman)
	num = subtractOnce(num, 500, "D", &roman)
	num = subtractOnce(num, 400, "CD", &roman)
	num = subtractRepeatidly(num, 100, "C", &roman)
	num = subtractOnce(num, 90, "XC", &roman)
	num = subtractRepeatidly(num, 50, "L", &roman)
	num = subtractOnce(num, 40, "XL", &roman)
	num = subtractRepeatidly(num, 10, "X", &roman)
	num = subtractOnce(num, 9, "IX", &roman)
	num = subtractOnce(num, 5, "V", &roman)
	num = subtractOnce(num, 4, "IV", &roman)
	num = subtractRepeatidly(num, 1, "I", &roman)

	return roman.String()
}

func main() {
	numbers := []int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 58, 60, 1994}

	for _, number := range numbers {
		fmt.Printf("%d => %s\n", number, intToRoman(number))
	}
}
