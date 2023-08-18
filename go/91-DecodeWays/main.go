package main

import "fmt"

func process(buffer []byte) int {
	if len(buffer) == 0 {
		return 1
	}

	if buffer[0] == byte('0') {
		return 0
	}

	if len(buffer) == 1 {
		return 1
	}

	if buffer[0] == byte('1') {
		if len(buffer) > 1 {
			if buffer[1] == byte('0') {
				return 2 + process(buffer[2:])
			} else {
				return 1 + process(buffer[2:])
			}
		} else {
			return process(buffer[1:]) + process(buffer[2:])
		}
	}

	if buffer[0] == byte('2') {
		if len(buffer) > 1 && buffer[1] > byte('6') {
			return process(buffer[1:])
		}

		return process(buffer[1:]) + process(buffer[2:])
	}

	return process(buffer[1:])
}

func numDecodings(s string) int {
	buffer := []byte(s)
	return process(buffer)
}

func main() {
	// TODO: finish this question
	fmt.Println(numDecodings("111111111111111111111111111111111111111111111"))
	//fmt.Println(numDecodings("2"))
	//fmt.Println(numDecodings("21"))
	//fmt.Println(numDecodings("26"))
	//fmt.Println(numDecodings("27"))
	//fmt.Println(numDecodings("226"))
	//fmt.Println(numDecodings("06"))
}
