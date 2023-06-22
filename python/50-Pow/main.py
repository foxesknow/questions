import unittest

class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n == 0 or x == 1:
            return 1

        if n == 1:
            return x

        if n == -1:
            return 1 / x

        if x == 0:
            return 0

        half = self.myPow(x, int(n / 2))        
        result = half * half

        if abs(n) % 2 == 1:
            sign = 1 if n > 0 else -1
            result *= self.myPow(x, sign)

        return result

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.myPow(2, 10), 1024)

    def test_example2(self):
        solution = Solution()
        self.assertAlmostEqual(solution.myPow(2.1, 3), 9.2610)

    def test_example3(self):
        solution = Solution()
        self.assertAlmostEqual(solution.myPow(2.0, -2), 0.2500)

    def test_example4(self):
        solution = Solution()
        self.assertAlmostEqual(solution.myPow(-2, 2), 4)

    def test_example5(self):
        solution = Solution()
        self.assertAlmostEqual(solution.myPow(34.00515, -3), 3e-05)

if __name__ == '__main__':
    unittest.main()
