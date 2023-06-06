import unittest

class Solution:
    def reverse(self, x: int) -> int:
        max_int = 2_147_483_647
        
        is_negative = (x < 0)
        x = abs(x)

        value: int = 0

        while x:
            next_digit = abs(x % 10)

            # Check for overflow
            if value != 0 and ((max_int - next_digit) // value) < 10:
                return 0
            
            value *= 10
            value += next_digit

            x = int(x / 10)

        if is_negative:
            value *= -1
        
        return value
    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.reverse(123) == 321)

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.reverse(-123) == -321)

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.reverse(120) == 21)



if __name__ == '__main__':
    unittest.main()