from typing import List
import unittest

class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for row in matrix:
            if row[0] > target:
                return False
            
            if row[-1] < target:
                continue
            
            if target in row:
                return True
            
        return False
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]
        self.assertTrue(solution.searchMatrix(matrix, 5))

    def test_example2(self):
        solution = Solution()
        matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]
        self.assertFalse(solution.searchMatrix(matrix, 20))


if __name__ == '__main__':
    unittest.main()
