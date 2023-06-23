import unittest

class Solution:
    def convertToTitle(self, columnNumber: int) -> str:
        title = ""

        # We subtract one to make the number zero based
        while columnNumber:
            index = (columnNumber - 1) % 26
            c = chr(65 + index)
            title = c + title

            columnNumber = (columnNumber - 1) // 26

        return title

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.convertToTitle(1), "A")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.convertToTitle(28), "AB")

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.convertToTitle(701), "ZY")


if __name__ == '__main__':
    unittest.main()
