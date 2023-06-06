import unittest

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        longest: int = 0
        start_index: int = 0
        index: int = 0
        window_size: int = 0
        
        seen = [False] * 256

        while index < len(s):
            c = s[index]
            
            if seen[ord(c)]:
                # We've reached the end of our run
                longest = max(longest, window_size)
                restart = index
                index = start_index

                while index < len(s) and c != s[index]:
                    seen[ord(s[index])] = False
                    index += 1
                    window_size -= 1

                start_index = index + 1
                index = restart + 1
            else:
                index += 1
                window_size += 1
                seen[ord(c)] = True
        
        return max(longest, window_size)
    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.lengthOfLongestSubstring("abcabcbb") == 3)

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.lengthOfLongestSubstring("bbbbb") == 1)

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.lengthOfLongestSubstring("pwwkew") == 3)


if __name__ == '__main__':
    unittest.main()