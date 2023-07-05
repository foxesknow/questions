from typing import List

import unittest

class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        nums.sort()
        results: List[int] = []

        frequency = int(len(nums) / 3)
        index = 0

        while index < len(nums) - frequency:
            if nums[index] == nums[index + frequency]:
                value = nums[index]
                results.append(value)
                index += 1
                while index < len(nums) and nums[index] == value:
                    index += 1
            else:
                index += 1


        return results

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([3,2,3]), [3])

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1]), [1])

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,2]), [1,2])

    def test_example4(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,1]), [1])

    def test_example5(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,1,1]), [1])

    def test_example6(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,1,1,1,1,1,1,1,1]), [1])

    def test_example7(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,2,1,2,2,1,1,1,2]), [1,2])

    def test_example8(self):
        solution = Solution()
        self.assertEqual(solution.majorityElement([1,2,3]), [])

if __name__ == '__main__':
    unittest.main()
