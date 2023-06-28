from typing import List

import unittest

class Solution:
    def countBits(self, n: int) -> List[int]:
        results = [0] * (n + 1)

        for i in range(0, n + 1):
            results[i] = results[i // 2] + (i & 1)

        return results;

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.countBits(2), [0,1,1])

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.countBits(5), [0,1,1,2,1,2])

if __name__ == '__main__':
    unittest.main()