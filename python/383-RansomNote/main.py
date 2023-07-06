import unittest

class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        frequency = [0] * 26

        for i in range(len(magazine)):
            c = magazine[i]
            position = ord(c) - ord('a')
            frequency[position] += 1

        for i in range(len(ransomNote)):
            c = ransomNote[i]
            position = ord(c) - ord('a')

            if frequency[position] == 0:
                return False
            
            frequency[position] -= 1

        return True

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertFalse(solution.canConstruct("a","b"))

    def test_example2(self):
        solution = Solution()
        self.assertFalse(solution.canConstruct("aa","ab"))

    def test_example3(self):
        solution = Solution()
        self.assertTrue(solution.canConstruct("aa","aab"))

if __name__ == '__main__':
    unittest.main()