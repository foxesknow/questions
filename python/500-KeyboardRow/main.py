from typing import List
import unittest

class Solution:
    def findWords(self, words: List[str]) -> List[str]:
        top = set("qwertyuiop")
        middle = set("asdfghjkl")
        bottom = set("zxcvbnm")

        results: List[str] = []

        for word in words:
            as_set = set(word.lower())
            if as_set.issubset(top) or as_set.issubset(middle) or as_set.issubset(bottom):
                results.append(word)

        return results
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.findWords(["Hello","Alaska","Dad","Peace"]), ["Alaska","Dad"])

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.findWords(["omk"]), [])

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.findWords(["adsdf","sfd"]), ["adsdf","sfd"])

if __name__ == '__main__':
    unittest.main()