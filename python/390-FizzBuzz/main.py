from typing import List
import unittest

class Solution:
    def fizzBuzz(self, n: int) -> List[str]:
        results = [""] * n

        for i in range(1, n + 1):
            if i % 15 == 0:
                results[i - 1] = "FizzBuzz"
            elif i % 3 == 0:
                results[i - 1] = "Fizz"
            elif i % 5 == 0:
                results[i - 1] = "Buzz"            
            else:
                results[i - 1] = str(i)

        return results
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.fizzBuzz(3), ["1", "2", "Fizz"])

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.fizzBuzz(5), ["1", "2", "Fizz", "4", "Buzz"])

if __name__ == '__main__':
    unittest.main()