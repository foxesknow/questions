from typing import List

import unittest

class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        count = 1

        current = nums[0]
        current_count = 1
        insertion_point = 1

        for i in range(1, len(nums)):
            num = nums[i]

            if current == num:
                if current_count != 2:
                    nums[insertion_point] = num
                    insertion_point += 1
                    current_count += 1
                    count += 1
            else:
                current_count = 1
                current = num
                nums[insertion_point] = num
                insertion_point += 1
                count += 1
        
        return count
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.removeDuplicates([1,1,1,2,2,3]), 5)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.removeDuplicates([0,0,1,1,1,1,2,3,3]), 7)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.removeDuplicates([0]), 1)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.removeDuplicates([1,1,1,2,2,3]), 5)

if __name__ == '__main__':
    unittest.main()