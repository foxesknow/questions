from typing import List

import unittest

class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        missing = nums[0]

        for i in range(1, len(nums)):
            missing ^= nums[i]

        return missing

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.singleNumber([2,2,1]), 1)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.singleNumber([1]), 1)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.singleNumber([3,5,6,2,6,3,5]), 2)

if __name__ == '__main__':
    unittest.main()
