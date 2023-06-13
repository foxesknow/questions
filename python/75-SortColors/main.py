from typing import List

import unittest

class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """

        red, white, blue = 0, 0, 0

        for num in nums:
            if num == 0:
                red +=1
            elif num == 1:
                white += 1
            else:
                blue += 1

        for i in range(red):
            nums[i] = 0

        for i in range(red, red + white):
            nums[i] = 1

        for i in range(red + white, red + white + blue):
            nums[i] = 2
        

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()

        nums = [2,0,2,1,1,0]
        solution.sortColors(nums)
        self.assertEqual(nums, [0,0,1,1,2,2])

    def test_example2(self):
        solution = Solution()

        nums = [2,0,1]
        solution.sortColors(nums)
        self.assertEqual(nums, [0,1,2])


if __name__ == '__main__':
    unittest.main()