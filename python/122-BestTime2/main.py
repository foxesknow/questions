from typing import List

import unittest

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        profit = 0

        for i in range(1, len(prices)):
            this_profit = prices[i] - prices[i - 1];
            profit += max(0, this_profit)

        return profit

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.maxProfit([7,1,5,3,6,4]), 7)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.maxProfit([1,2,3,4,5]), 4)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.maxProfit([7,6,4,3,1]), 0)

if __name__ == '__main__':
    unittest.main()
