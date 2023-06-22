import unittest

class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n == 0 or x == 1:
            return 1

        if n == 1:
            return x

        if x == 0:
            return 0

        result = 1
        scaling = abs(n)
        is_negative = (n < 0)
        
        for i in range(abs(n)):
            if is_negative:
                result /= x
            else:
                result *= x

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

if __name__ == '__main__':
    unittest.main()
