from typing import List
import unittest


class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        squares = [0] * 9
        rows = [0] * 9
        columns = [0] * 9

        for r, row in enumerate(board):
            for c, col in enumerate(row):
                if col == '.':
                    continue

                value = int(col)
                bit = 1 << value

                if (rows[r] & bit) != 0:
                    return False
                else:
                    rows[r] |= bit

                if (columns[c] & bit) != 0:
                    return False
                else:
                    columns[c] |= bit

                # Work out which square we're in
                s = ((r // 3) * 3) + (c // 3)
                if (squares[s] & bit) != 0:
                    return False
                else:
                    squares[s] |= bit

        return True

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()

        board = [["5","3",".",".","7",".",".",".","."]
        ,["6",".",".","1","9","5",".",".","."]
        ,[".","9","8",".",".",".",".","6","."]
        ,["8",".",".",".","6",".",".",".","3"]
        ,["4",".",".","8",".","3",".",".","1"]
        ,["7",".",".",".","2",".",".",".","6"]
        ,[".","6",".",".",".",".","2","8","."]
        ,[".",".",".","4","1","9",".",".","5"]
        ,[".",".",".",".","8",".",".","7","9"]]

        self.assertTrue(solution.isValidSudoku(board))

    def test_example2(self):
        solution = Solution()

        board = [["8","3",".",".","7",".",".",".","."]
        ,["6",".",".","1","9","5",".",".","."]
        ,[".","9","8",".",".",".",".","6","."]
        ,["8",".",".",".","6",".",".",".","3"]
        ,["4",".",".","8",".","3",".",".","1"]
        ,["7",".",".",".","2",".",".",".","6"]
        ,[".","6",".",".",".",".","2","8","."]
        ,[".",".",".","4","1","9",".",".","5"]
        ,[".",".",".",".","8",".",".","7","9"]]

        self.assertFalse(solution.isValidSudoku(board))




if __name__ == '__main__':
    unittest.main()