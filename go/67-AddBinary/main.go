package main

import (
	"fmt"
	"strings"
)

func nextDigit(s string, index int) byte {
	if index >= 0 {
		return s[index] - byte(int('0'))
	}

	return 0
}

func addBinary(a string, b string) string {
	buffer := make([]byte, 0, len(a)+len(b)+1)

	// We need to add the characters from right to left
	offsetA := len(a) - 1
	offsetB := len(b) - 1
	carry := byte(0)

	for offsetA >= 0 || offsetB >= 0 || carry == 1 {
		bitA := nextDigit(a, offsetA)
		bitB := nextDigit(b, offsetB)

		sum := bitA + bitB + carry
		buffer = append(buffer, sum%2)
		carry = sum / 2

		offsetA--
		offsetB--
	}

	var builder strings.Builder
	builder.Grow(len(buffer))

	// The bits are back to front
	for i := len(buffer) - 1; i >= 0; i-- {
		builder.WriteByte(byte('0') + buffer[i])
	}

	return builder.String()
}

func main() {
	fmt.Println(addBinary("11", "1"))
	fmt.Println(addBinary("1010", "1011"))
}
