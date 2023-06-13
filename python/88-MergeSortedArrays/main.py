from typing import List

import unittest

class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        insertion_point = len(nums1) - 1

        m -= 1
        n -= 1

        while m != -1 or n != -1:
            if m == -1:
                nums1[insertion_point] = nums2[n]
                n -= 1
            elif n == -1:
                nums1[insertion_point] = nums1[m]
                m -= 1
            else:
                if nums1[m] > nums2[n]:
                    nums1[insertion_point] = nums1[m]
                    m -= 1
                else:
                    nums1[insertion_point] = nums2[n]
                    n -= 1

            insertion_point -= 1

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        data = [1,2,3,0,0,0]
        solution.merge(data, 3, [2,5,6], 3)
        self.assertEquals(data, [1,2,2,3,5,6])

    def test_example2(self):
        solution = Solution()
        data = [1]
        solution.merge(data, 1, [], 0)
        self.assertEquals(data, [1])

    def test_example3(self):
        solution = Solution()
        data = [0]
        solution.merge(data, 0, [1], 1)
        self.assertEquals(data, [1])

if __name__ == '__main__':
    unittest.main()