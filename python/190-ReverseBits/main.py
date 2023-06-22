import unittest

class Solution:
    def reverseBits(self, n: int) -> int:
        result = 0

        for i in range(32):
            result <<= 1
            result |= (n & 1)
            n >>= 1

        return result

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.reverseBits(0b00000010100101000001111010011100), 0b00111001011110000010100101000000)

if __name__ == '__main__':
    unittest.main()
