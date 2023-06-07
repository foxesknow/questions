from typing import List
import unittest

class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if len(strs) == 1:
            return strs[0]

        strs.sort()

        first = strs[0]
        last = strs[-1]
        length = min(len(first), len(last))

        prefix = ""

        for index in range(length):
            if first[index] == last[index]:
                prefix += first[index]
            else:
                break
            
        return prefix
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.longestCommonPrefix(["flower","flow","flight"]) == "fl")

    def test_example2(self):
        solution = Solution()
        self.assertTrue(solution.longestCommonPrefix(["dog","racecar","car"]) == "")

if __name__ == '__main__':
    unittest.main()