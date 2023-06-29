import unittest

class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        return n and (n & (n - 1) == 0)

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.isPowerOfTwo(1))

    def test_various_are_powers(self):
        solution = Solution()
        self.assertTrue(solution.isPowerOfTwo(1))
        self.assertTrue(solution.isPowerOfTwo(2))
        self.assertTrue(solution.isPowerOfTwo(4))
        self.assertTrue(solution.isPowerOfTwo(8))
        self.assertTrue(solution.isPowerOfTwo(16))

    def test_various_are_not_powers(self):
        solution = Solution()
        self.assertFalse(solution.isPowerOfTwo(3))
        self.assertFalse(solution.isPowerOfTwo(5))
        self.assertFalse(solution.isPowerOfTwo(6))

if __name__ == '__main__':
    unittest.main()