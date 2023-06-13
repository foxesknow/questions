from typing import List

import unittest

class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        max_rows = len(board)
        max_columns = len(board[0])

        def can_match(index: int, row: int, column:int) -> bool:
            if index == len(word):
                return True

            if row == -1 or column == -1:
                return False
            
            if row == max_rows or column == max_columns:
                return False
            
            char = board[row][column]
            if char == '.' or char != word[index]:
                return False
            
            try:
                board[row][column] = "."

                if can_match(index + 1, row - 1, column): return True
                if can_match(index + 1, row + 1, column): return True
                if can_match(index + 1, row, column - 1): return True
                if can_match(index + 1, row, column + 1): return True

                return False

            finally:
                board[row][column] = char

        for row in range(max_rows):
            for column in range(max_columns):
                if board[row][column] == word[0]:
                    if can_match(0, row, column):
                        return True
                    
        return False

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.exist([["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], "SEE"))

    def test_example1(self):
        solution = Solution()
        self.assertFalse(solution.exist([["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], "ABCB"))

if __name__ == '__main__':
    unittest.main()