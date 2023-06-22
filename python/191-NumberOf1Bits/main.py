import unittest

class Solution:
    def hammingWeight(self, n: int) -> int:
        count = 0

        while n:
            count += (n & 1)
            n >>= 1

        return count

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.hammingWeight(0b00000000000000000000000000001011), 3)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.hammingWeight(0b00000000000000000000000010000000), 1)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.hammingWeight(0b11111111111111111111111111111101), 31)

    def test_example4(self):
        solution = Solution()
        self.assertEqual(solution.hammingWeight(0b00000000000000000000000000000000), 0)

if __name__ == '__main__':
    unittest.main()
