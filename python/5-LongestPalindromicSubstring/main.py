import unittest

class Solution:
    def longestPalindrome(self, s: str) -> str:
        result = ""

        for index, _ in enumerate(s):
            sub = self.get_palindrome(s, index - 1, index + 1)
            if sub and len(sub) > len(result) :
                result = sub

            sub = self.get_palindrome(s, index, index + 1)
            if sub and len(sub) > len(result) :
                result = sub

        return result
    
    def get_palindrome(self, s: str, left: int, right: int) -> str:
        while left >= 0 and right < len(s):
            if s[left] == s[right]:
                left -= 1
                right += 1
            else:
                break

        palindrome = s[left + 1 : right]
        return palindrome if len(palindrome) > 0 else ""
    
    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.longestPalindrome("babad") == "bab")

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.longestPalindrome("cbbd") == "bb")



if __name__ == '__main__':
    unittest.main()