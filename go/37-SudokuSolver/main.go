package main

import (
	"fmt"
	"strconv"
)

var (
	rows    [9]int
	columns [9]int
	squares [9]int
)

func initialize(board [][]byte) {
	for i := 0; i < 9; i++ {
		rows[i] = 0
		columns[i] = 0
		squares[i] = 0
	}

	for r, row := range board {
		for c, value := range row {
			if value != byte('.') {
				turnOn(r, c, int(value-'0'))
			}
		}
	}
}

func selectEmptyCell(board [][]byte) (int, int) {
	for r, row := range board {
		for c, value := range row {
			if value == byte('.') {
				return r, c
			}
		}
	}

	return -1, -1
}

func turnOn(row, col, number int) {
	bit := 1 << number
	rows[row] |= bit
	columns[col] |= bit

	s := getSquare(row, col)
	squares[s] |= bit
}

func turnOff(row, col, number int) {
	bitMask := ^(1 << number)
	rows[row] &= bitMask
	columns[col] &= bitMask

	s := getSquare(row, col)
	squares[s] &= bitMask
}

func getSquare(row, col int) int {
	s := ((row / 3) * 3) + (col / 3)
	return s
}

func canPlace(row, col, number int) bool {
	bit := 1 << number

	if (rows[row] & bit) != 0 {
		return false
	}

	if (columns[col] & bit) != 0 {
		return false
	}

	s := getSquare(row, col)
	if (squares[s] & bit) != 0 {
		return false
	}

	return true
}

func recurse(board [][]byte) bool {
	r, c := selectEmptyCell(board)

	if r == -1 && c == -1 {
		return true
	}

	for number := 1; number < 10; number++ {
		if canPlace(r, c, number) {
			board[r][c] = byte(number + '0')
			turnOn(r, c, number)

			if recurse(board) {
				return true
			}

			board[r][c] = byte('.')
			turnOff(r, c, number)
		}
	}

	return false
}

func solveSudoku(board [][]byte) {
	initialize(board)
	recurse(board)
}

func printBoard(board [][]byte) {
	for _, row := range board {
		for _, c := range row {
			fmt.Printf("%d ", int(c-'0'))
		}

		fmt.Println()
	}
}

func makeBoard(board [][]string) [][]byte {
	var newBoard [][]byte

	for _, row := range board {
		r := make([]byte, 0, 9)

		for _, s := range row {
			if s == "." {
				r = append(r, byte('.'))
			} else {
				n, _ := strconv.Atoi(s)
				r = append(r, byte('0')+byte(n))
			}
		}

		newBoard = append(newBoard, r)
	}

	return newBoard
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

	for _, row := range board {
		for c, col := range row {
			if col != byte('.') {
				row[c] += byte('0')
			}
		}
	}

	solveSudoku(board)
	printBoard(board)
}

func test2() {
	sboard := [][]string{
		{".", ".", "9", "7", "4", "8", ".", ".", "."},
		{"7", ".", ".", ".", ".", ".", ".", ".", "."},
		{".", "2", ".", "1", ".", "9", ".", ".", "."},
		{".", ".", "7", ".", ".", ".", "2", "4", "."},
		{".", "6", "4", ".", "1", ".", "5", "9", "."},
		{".", "9", "8", ".", ".", ".", "3", ".", "."},
		{".", ".", ".", "8", ".", "3", ".", "2", "."},
		{".", ".", ".", ".", ".", ".", ".", ".", "6"},
		{".", ".", ".", "2", "7", "5", "9", ".", "."},
	}

	board := makeBoard(sboard)
	solveSudoku(board)
	printBoard(board)
}

func main() {
	test1()
	fmt.Println()
	test2()
}
