from typing import List
import unittest

class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        lower, upper = 0, len(nums)

        while lower <= upper:
            mid = (lower + upper) // 2

            if nums[mid] == target:
                return mid
            
            if mid == lower:
                return mid if nums[mid] > target else mid + 1
            
            if nums[mid] > target:
                upper = mid - 1
            else:
                lower = mid + 1



class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.searchInsert([1,3,5,6], 5) == 2)

    def test_example2(self):
        solution = Solution()
        self.assertTrue(solution.searchInsert([1,3,5,6], 2) == 1)

    def test_example3(self):
        solution = Solution()
        self.assertTrue(solution.searchInsert([1,3,5,6], 7) == 4)

    def test_example4(self):
        solution = Solution()
        self.assertTrue(solution.searchInsert([1], 1) == 0)

    def test_example5(self):
        solution = Solution()
        self.assertTrue(solution.searchInsert([5,10,15], 1) == 0)

if __name__ == '__main__':
    unittest.main()