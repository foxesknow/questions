from typing import List, Tuple
import unittest

class Solution:
    def __init__(self) -> None:
        self.squares = [0] * 9
        self.rows = [0] * 9
        self.columns = [0] * 9
        self.numberCache = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]

    def getSquare(self, row: int, col: int) -> int:
        s = ((row // 3) * 3) + (col // 3)
        return s
    
    def selectEmptyCell(self, board: List[List[str]]) -> Tuple[int, int]:
        for r, row in enumerate(board):
            for c, col in enumerate(row):
                if col == '.':
                     return (r, c)
                
        return (-1, -1)
    
    def initialise(self, board: List[List[str]]) -> None:
        for r, row in enumerate(board):
            for c, col in enumerate(row):
                if col != '.' :
                    value = int(col)
                    self.turnOn(r, c, value)

    def turnOn(self, row: int, col: int, number: int) -> None:
        bit = 1 << number
        self.rows[row] |= bit
        self.columns[col] |= bit

        s = self.getSquare(row, col)
        self.squares[s] |= bit

    def turnOff(self, row: int, col: int, number: int) -> None:
        bit = 1 << number
        self.rows[row] &= ~bit
        self.columns[col] &= ~bit

        s = self.getSquare(row, col)
        self.squares[s] &= ~bit

    def canPlace(self, row: int, col: int, number: int) -> bool:
        bit = 1 << number

        if self.rows[row] & bit != 0:
            return False
        
        if self.columns[col] & bit != 0:
            return False
        
        s = self.getSquare(row, col)
        if self.squares[s] & bit != 0:
            return False
        
        return True

    def recurse(self, board: List[List[str]]) -> bool:
        row, column = self.selectEmptyCell(board)

        if row == -1 and column == -1:
            return True
        
        for number in range(1, 10):
            if self.canPlace(row, column, number):
                board[row][column] = self.numberCache[number]
                self.turnOn(row, column, number)

                if self.recurse(board):
                    return True
                
                board[row][column] = "."
                self.turnOff(row, column, number)
                
        board[row][column] = "."
        return False
                
                
    def solveSudoku(self, board: List[List[str]]) -> None:
        self.initialise(board)
        self.recurse(board)

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

        solution.solveSudoku(board)

        for row in board:
            print(row)



if __name__ == '__main__':
    unittest.main()