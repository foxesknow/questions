import unittest

class Solution:
    def findTheDifference(self, s: str, t: str) -> str:
            frequency = [0] * 26

            for i in range(len(t)):
                  index = ord(t[i]) - ord("a")
                  frequency[index] += 1

            for i in range(len(s)):
                  index = ord(s[i]) - ord("a")
                  frequency[index] -= 1

            index = next(i for i, x in enumerate(frequency) if x != 0)
            return chr(97 + index)

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.findTheDifference("abcd", "abcde"), "e")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.findTheDifference("", "y"), "y")

if __name__ == '__main__':
    unittest.main()