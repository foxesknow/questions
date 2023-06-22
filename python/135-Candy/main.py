from typing import List

import unittest

class Solution:
    def candy(self, ratings: List[int]) -> int:
        totals = [1] * len(ratings)
        length = len(ratings)

        for i in range(1, length):
            if ratings[i] > ratings[i - 1]:
                totals[i] = totals[i - 1] + 1

        for i in range(length - 2, -1, -1):
            if ratings[i] > ratings[i + 1]:
                totals[i] = max(totals[i], totals[i + 1] + 1)

        return sum(totals)

class Tests(unittest.TestCase):
    def xtest_example1(self):
        solution = Solution()
        self.assertEqual(solution.candy([1,0,2]), 5)

    def xtest_example2(self):
        solution = Solution()
        self.assertEqual(solution.candy([1,2,2]), 4)

    def xtest_example3(self):
        solution = Solution()
        self.assertEqual(solution.candy([1,2,87,87,87,2,1]), 13)

    def test_example4(self):
        solution = Solution()
        self.assertEqual(solution.candy([29,51,87,87,72,12]), 12)

if __name__ == '__main__':
    unittest.main()
