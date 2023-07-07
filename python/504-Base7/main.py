import unittest

class Solution:
    def convertToBase7(self, num: int) -> str:
        if num == 0:
            return "0"

        is_negative = num < 0
        num = abs(num)

        result = ""

        while num:
            num, rem = divmod(num, 7)
            result += str(rem)

        result = result[::-1]
        if is_negative:
            result = "-" + result

        return result
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.convertToBase7(100), "202")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.convertToBase7(-7), "-10")

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.convertToBase7(0), "0")

if __name__ == '__main__':
    unittest.main()
        