import unittest

class Solution:
    def isUgly(self, n: int) -> bool:
        if n == 1: return True
        if n < 1: return False

        if n % 2 == 0 and self.isUgly(n // 2): return True
        if n % 3 == 0 and self.isUgly(n // 3): return True
        if n % 5 == 0 and self.isUgly(n // 5): return True

        return False
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.isUgly(6))

    def test_example2(self):
        solution = Solution()
        self.assertTrue(solution.isUgly(1))

    def test_example3(self):
        solution = Solution()
        self.assertFalse(solution.isUgly(14))

    def test_example4(self):
        solution = Solution()
        self.assertTrue(solution.isUgly(30))


if __name__ == '__main__':
    unittest.main()
