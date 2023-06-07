import unittest

class Solution:
    def myAtoi(self, s: str) -> int:
        # First, trim and leading whitespace
        for index, c in enumerate(s):
            if c != ' ':
                break
        else:
             index = 0
            
        if index == len(s):
            return 0
        
        # Check for a sign
        positive = True
        if s[index] == '+':
            positive = True
            index += 1
        elif s[index] == '-':
            positive = False
            index += 1

        value = 0

        for i in range(index, len(s)):
            c = s[i]
            if c.isdigit():
                value *= 10
                value += int(c)
            else:
                break
            
        if not positive:
            value *= -1

        if value > 2147483647:
            return 2147483647
        elif value < -2147483648:
            return -2147483648
        
        return value
        

class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("42") == 42)

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("   -42") == -42)

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("4193 with words") == 4193)

    def test_example4(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("+42") == 42)

    def test_example5(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("-42") == -42)

    def test_example6(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("-91283472332") == -2147483648)

    def test_example7(self):
          solution = Solution()
          self.assertTrue(solution.myAtoi("") == 0)



if __name__ == '__main__':
    unittest.main()