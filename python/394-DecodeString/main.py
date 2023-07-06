from typing import Tuple
import unittest

class Solution:
    def decodeString(self, s: str) -> str:
        result, _ = self.expand(s, 0)
        return result
    
    def expand(self, s: str, index: int) -> Tuple[str, int]:
        result = ""

        while index < len(s):
            if self.is_integer(s, index):
                number = self.extract_number(s, index)
                index += len(number)

                # The next character is a [, so move over it to the next value
                index += 1
                inner, index = self.expand(s, index)
                result += (int(number) * inner)

            elif self.is_letter(s, index):
                result += s[index]
                index += 1

            elif self.is_close(s, index):
                index += 1
                break

        return result, index
    
    def is_integer(self, s: str, index: int) -> bool:
        c = s[index]
        return c >= "0" and c <= "9"
    
    def is_letter(self, s: str, index: int) -> bool:
        c = s[index]
        return c >= "a" and c <= "z"
    
    def is_close(self, s: str, index: int) -> bool:
        c = s[index]
        return c == "]"
    
    def extract_number(self, s: str, index: int) -> str:
        number = ""

        while index < len(s) and self.is_integer(s, index):
            number += s[index]
            index += 1

        return number

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.decodeString("3[a]2[bc]"), "aaabcbc")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.decodeString("3[a2[c]]"), "accaccacc")

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.decodeString("2[abc]3[cd]ef"), "abcabccdcdcdef")

if __name__ == '__main__':
    unittest.main()