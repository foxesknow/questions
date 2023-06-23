import unittest

class Solution:
    def titleToNumber(self, columnTitle: str) -> int:
        n = 0

        for i in range(len(columnTitle)):
            # Grab the next letter
            letter = columnTitle[i]

            # Convert it to its 1-based value (A = 1, B = 2) etc
            # ord("A") is 65, so we subtract 64 to get the 1-based value
            value = ord(letter) - 64
            
            # Scale up the existing value...
            n *= 26

            # ...and add in the next value
            n += value

        return n

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.titleToNumber("A"), 1)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.titleToNumber("AB"), 28)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.titleToNumber("ZY"), 701)


if __name__ == '__main__':
    unittest.main()
