import unittest

class Solution:
    def isPowerOfFour(self, n: int) -> bool:
        if n <= 0: return False

        # A power of 4 will only have 1 bit set
        if n & (n - 1) != 0: return False

        # We just mask the value now with the "power of 4" values
        mask = 0b01010101_01010101_01010101_01010101
        return (n & mask) == n
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.isPowerOfFour(16))

    def test_example2(self):
        solution = Solution()
        self.assertFalse(solution.isPowerOfFour(5))

    def test_example3(self):
        solution = Solution()
        self.assertTrue(solution.isPowerOfFour(1))

    def test_example4(self):
        solution = Solution()
        self.assertFalse(solution.isPowerOfFour(0))
    

if __name__ == '__main__':
    unittest.main()