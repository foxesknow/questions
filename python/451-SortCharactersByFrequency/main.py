from typing import Dict
import unittest

class Solution:
    def frequencySort(self, s: str) -> str:
        frequencies: Dict[str, int] = {}

        for i in range(len(s)):
            c = s[i]

            if c in frequencies:
                frequencies[c] = frequencies[c] + 1
            else:
                frequencies[c] = 1

        items = list(frequencies.items())
        items.sort(reverse = True, key = lambda tuple: tuple[1])

        result = ""

        for pair in items:
            char = pair[0]
            count = pair[1]

            result += char * count

        return result
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        print(solution.frequencySort("tree"))

if __name__ == '__main__':
    unittest.main()