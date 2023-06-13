from typing import List

import unittest

class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        result = [0] * (len(digits) + 1)

        carry = 0
        input = len(digits) - 1
        output = len(result) - 1
        add = 1

        while input != -1:
            sum = digits[input] + add + carry
            result[output] = sum % 10
            carry = sum // 10

            input -= 1
            output -= 1
            add = 0

        if carry != 0:
            result[output] = 1

        if result[0] == 0:
            return result[1:]
        else:
            return result
        
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.plusOne([1,2,3]), [1,2,4])

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.plusOne([4,3,2,1]), [4,3,2,2])

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.plusOne([9,9]), [1,0,0])


if __name__ == '__main__':
    unittest.main()