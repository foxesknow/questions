from typing import List

import unittest

class Solution:
    def rotate(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """

        length = len(nums)
        k = k % length

        if k == length or k == 0:
            return

        if length < 2:
            return

        self.reverse(nums, 0, length - 1)
        self.reverse(nums, 0, k - 1)
        self.reverse(nums, k, length - 1)

        

    def swap(self, nums: List[int], i: int, j: int):
        temp = nums[i]
        nums[i] = nums[j]
        nums[j] = temp

    def reverse(self, nums: List[int], i: int, j: int):
        while i < j:
            self.swap(nums, i, j)
            i += 1
            j -= 1

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        nums = [1,2,3,4,5,6,7]
        solution.rotate(nums, 3)
        self.assertEqual(nums, [5,6,7,1,2,3,4])

    def test_example2(self):
        solution = Solution()
        nums = [1,2,3,4,5,6,7]
        solution.rotate(nums, 10)
        self.assertEqual(nums, [5,6,7,1,2,3,4])


if __name__ == '__main__':
    unittest.main()
