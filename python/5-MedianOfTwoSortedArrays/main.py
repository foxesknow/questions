from typing import List
from typing import Optional
import unittest

class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        
        if len(nums1) == 0:
            return self.median(nums2)
        
        if len(nums2) == 0:
            return self.median(nums1)

        combined_length = len(nums1) + len(nums2)
        items_to_consider = int(combined_length / 2)
        items_to_consider += 1 # if combined_length % 2 == 0 else 0

        cursor_1 = 0 if len(nums1) else None
        cursor_2 = 0 if len(nums2) else None

        current = None
        previous = None

        while items_to_consider != 0:
            previous = current
            if cursor_1 is not None and cursor_2 is not None:
                if nums1[cursor_1] <= nums2[cursor_2]:
                    current = nums1[cursor_1]
                    cursor_1 = self.next_index(cursor_1, nums1)
                else:
                    current = nums2[cursor_2]
                    cursor_2 = self.next_index(cursor_2, nums2)
            elif cursor_1 is not None:
                current = nums1[cursor_1]
                cursor_1 = self.next_index(cursor_1, nums1)
            else:
                current = nums2[cursor_2]
                cursor_2 = self.next_index(cursor_2, nums2)

            items_to_consider -= 1

        if combined_length % 2 == 1:
            return current
        else:
            return (current + previous) / 2

                

    def next_index(self, current_index: int, nums : List[int]) -> Optional[int]:
        current_index += 1
        return current_index if current_index < len(nums) else None
    
    def median(self, nums: List[int]) -> float:
        length = len(nums)
        mid = length // 2

        if length % 2 == 0:
            return (nums[mid] + nums[mid - 1]) / 2
        else:
            return nums[mid]
    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.findMedianSortedArrays([1,2], [3,4]) == 2.5)

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.findMedianSortedArrays([1,3], [2]) == 2)

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.findMedianSortedArrays([1,3,5], []) == 3)

    def test_example4(self):
          solution = Solution()
          self.assertTrue(solution.findMedianSortedArrays([1,3,5,7], []) == 4)

    def test_example5(self):
          solution = Solution()
          self.assertTrue(solution.findMedianSortedArrays([1,3,5,7], [2,4,6]) == 4)


if __name__ == '__main__':
    unittest.main()