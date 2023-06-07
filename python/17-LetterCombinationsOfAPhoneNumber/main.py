from typing import List
import unittest

class Solution:
    def letterCombinations(self, digits: str) -> List[str]:
        accumulator = []

        buttons = { "2" : "abc", "3" : "def",
                  "4" : "ghi", "5" : "jkl", "6" : "mno",
                  "7" : "pqrs", "8" : "tuv", "9" : "wxyz"
                  }
        
        self.recurse(digits, accumulator, buttons, "")

        return accumulator
        
    def recurse(self, digits:str, accumulator, buttons, current):
        if not digits:
            if current:
                accumulator.append(current)
            return
        
        number = digits[0]
        rest = digits[1:]

        letters = buttons[number]

        for c in letters:
            self.recurse(rest, accumulator, buttons, current + c)

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        s = solution.letterCombinations("23")
        print(s)

if __name__ == '__main__':
    unittest.main()