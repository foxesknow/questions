import unittest

class Solution:
    def multiply(self, num1: str, num2: str) -> str:
        if num1 == "0" or num2 == "0":
            return "0"

        numbers = [0] * (len(num1) + len(num2))

        for index_1, n1 in reversed(list(enumerate(num1))):
            for index_2, n2 in reversed(list(enumerate(num2))):
                product = int(n1) * int(n2)

                # We do += to accumulate any carry or value that is already here
                numbers[index_1 + index_2 + 1] += product

                # Move any carry into the cell to the left
                numbers[index_1 + index_2] += numbers[index_1 + index_2 + 1] // 10
                
                # Tidy up the number now we've done the carry
                numbers[index_1 + index_2 + 1] %= 10

        first_non_zero = 0
        while numbers[first_non_zero] == 0:
            first_non_zero += 1

        result = ""
        for i in range(first_non_zero, len(numbers)):
            result += str(numbers[i])

        return result
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.multiply("2", "3"), "6")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.multiply("123", "456"), "56088")

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.multiply("0", "456"), "0")

    def test_example4(self):
        solution = Solution()
        self.assertEqual(solution.multiply("123", "0"), "0")

    def test_example5(self):
        solution = Solution()
        self.assertEqual(solution.multiply("23", "42"), "966")


if __name__ == '__main__':
    unittest.main()