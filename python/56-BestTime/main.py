from typing import List

import unittest

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        minStockPrice = prices[0]
        profit = 0

        for i in range(1, len(prices)):
            this_profit = prices[i] - minStockPrice
            profit = max(profit, this_profit)
            minStockPrice = min(minStockPrice, prices[i])

        return profit

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.maxProfit([7,1,5,3,6,4]), 5)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.maxProfit([7,6,4,3,1]), 0)

if __name__ == '__main__':
    unittest.main()
