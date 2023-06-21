from typing import List

import unittest

class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        words = set(wordDict)

        def solve(word) -> bool:
            if len(word) == 0:
                return True

            for i in range(len(word), 0, -1):
                sub_str = word[0 : i]

                if sub_str in words and solve(word[i:]):
                    return True

            return False

        return solve(s)


class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.wordBreak("leetcode", ["leet", "code"]))

    def test_example2(self):
        solution = Solution()
        self.assertFalse(solution.wordBreak("catsandog", ["cats","dog","sand","and","cat"]))

    def test_example3(self):
        solution = Solution()
        self.assertFalse(solution.wordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab",
             ["a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa"]))

if __name__ == '__main__':
    unittest.main()
