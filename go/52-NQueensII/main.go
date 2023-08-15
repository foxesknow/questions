package main

import (
	"fmt"
	"math"
)

const EMPTY int = -1

func doesIntersect(q1Row, q1Col, q2Row, q2Col int) bool {
	if q1Col == q2Col {
		return true
	}

	rowAbs := int(math.Abs(float64(q1Row - q2Row)))
	colAbs := int(math.Abs(float64(q1Col - q2Col)))

	return rowAbs == colAbs
}

func isSafe(board []int, row, column int) bool {
	for boardRow := range board {
		if board[boardRow] == EMPTY {
			return true
		}

		if doesIntersect(row, column, boardRow, board[boardRow]) {
			return false
		}
	}

	return true
}

func solve(board []int, row int) int {
	if len(board) == row {
		return 1
	}

	solutions := 0

	for column := range board {
		if isSafe(board, row, column) {
			board[row] = column
			solutions += solve(board, row+1)
			board[row] = EMPTY
		}
	}

	return solutions
}

func totalNQueens(n int) int {
	board := make([]int, n)

	for i := range board {
		board[i] = EMPTY
	}

	return solve(board, 0)
}

func main() {
	fmt.Println(totalNQueens(4))
	fmt.Println(totalNQueens(1))
	fmt.Println(totalNQueens(8))
}
