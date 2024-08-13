package main

import "fmt"

func lengthOfLongestSubstring(s string) int {
	if len(s) == 0 {
		return 0
	}

	var seen [256]bool
	seen[s[0]] = true

	var left = 0
	var maxLength = 1

	for i := 1; i < len(s); i++ {
		c := s[i]

		if !seen[c] {
			seen[c] = true
			maxLength = max(maxLength, i-left+1)
			continue
		}

		// We need need to move left to the first character after c from the left
		left++
		for s[left-1] != c {
			seen[s[left-1]] = false
			left++
		}
	}

	return maxLength
}

func test1() {
	fmt.Println(lengthOfLongestSubstring("abcabcbb"))
}

func test2() {
	fmt.Println(lengthOfLongestSubstring("bbbb"))
}

func test3() {
	fmt.Println(lengthOfLongestSubstring("pwwkew"))
}

func main() {
	test1()
	test2()
	test3()
}
