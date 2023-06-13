from typing import List
import unittest

class Solution:
    def totalNQueens(self, n: int) -> int:
        board = [None] * n
        return self.solve(board, 0)
    
    def solve(self, board: List[int], row: int) -> int:
        if len(board) == row:
            return 1
        
        solutions = 0

        for column in range(len(board)):
            if self.is_safe(board, row, column):
                board[row] = column
                solutions += self.solve(board, row + 1)
                board[row] = None

        return solutions

        

    def is_safe(self, board: List[int], row: int, column: int) -> bool:
        for row_index in range(len(board)):
            if board[row_index] is None:
                return True
            
            if self.does_intersect(row, column, row_index, board[row_index]):
                return False
            
        return True
    
    def does_intersect(self, q1_row: int, q1_col: int, q2_row: int, q2_col: int) -> bool:
        if q1_col == q2_col:
            return True
        
        row_abs = abs(q1_row - q2_row)
        col_abs = abs(q1_col - q2_col)

        return row_abs == col_abs
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.totalNQueens(4), 2)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.totalNQueens(1), 1)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.totalNQueens(8), 92)

if __name__ == '__main__':
    unittest.main()