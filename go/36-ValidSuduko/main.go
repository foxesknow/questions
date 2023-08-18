package main

import "fmt"

func isValidSudoku(board [][]byte) bool {
	// We'll use the bit positions within the int to
	// flag if a number is present or not
	squares := make([]int, 9)
	rows := make([]int, 9)
	columns := make([]int, 9)

	for r, row := range board {
		for c, col := range row {
			if col == byte('.') {
				continue
			}

			bit := 1 << int(col)

			if rows[r]&bit != 0 {
				return false
			} else {
				rows[r] |= bit
			}

			if columns[c]&bit != 0 {
				return false
			} else {
				columns[c] |= bit
			}

			// Now check the square
			s := ((r / 3) * 3) + (c / 3)
			if squares[s]&bit != 0 {
				return false
			} else {
				squares[s] |= bit
			}
		}
	}

	return true
}

func test1() {
	board := [][]byte{
		{5, 3, byte('.'), byte('.'), 7, byte('.'), byte('.'), byte('.'), byte('.')},
		{6, byte('.'), byte('.'), 1, 9, 5, byte('.'), byte('.'), byte('.')},
		{byte('.'), 9, 8, byte('.'), byte('.'), byte('.'), byte('.'), 6, byte('.')},
		{8, byte('.'), byte('.'), byte('.'), 6, byte('.'), byte('.'), byte('.'), 3},
		{4, byte('.'), byte('.'), 8, byte('.'), 3, byte('.'), byte('.'), 1},
		{7, byte('.'), byte('.'), byte('.'), 2, byte('.'), byte('.'), byte('.'), 6},
		{byte('.'), 6, byte('.'), byte('.'), byte('.'), byte('.'), 2, 8, byte('.')},
		{byte('.'), byte('.'), byte('.'), 4, 1, 9, byte('.'), byte('.'), 5},
		{byte('.'), byte('.'), byte('.'), byte('.'), 8, byte('.'), byte('.'), 7, 9},
	}
	fmt.Println(isValidSudoku(board))
}

func test2() {
	board := [][]byte{
		{8, 3, byte('.'), byte('.'), 7, byte('.'), byte('.'), byte('.'), byte('.')},
		{6, byte('.'), byte('.'), 1, 9, 5, byte('.'), byte('.'), byte('.')},
		{byte('.'), 9, 8, byte('.'), byte('.'), byte('.'), byte('.'), 6, byte('.')},
		{8, byte('.'), byte('.'), byte('.'), 6, byte('.'), byte('.'), byte('.'), 3},
		{4, byte('.'), byte('.'), 8, byte('.'), 3, byte('.'), byte('.'), 1},
		{7, byte('.'), byte('.'), byte('.'), 2, byte('.'), byte('.'), byte('.'), 6},
		{byte('.'), 6, byte('.'), byte('.'), byte('.'), byte('.'), 2, 8, byte('.')},
		{byte('.'), byte('.'), byte('.'), 4, 1, 9, byte('.'), byte('.'), 5},
		{byte('.'), byte('.'), byte('.'), byte('.'), 8, byte('.'), byte('.'), 7, 9},
	}
	fmt.Println(isValidSudoku(board))
}

func main() {
	test1()
	test2()
}
