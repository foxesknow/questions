import unittest

class Solution:
    def mySqrt(self, x: int) -> int:
        if x == 0 or x == 1:
            return x
        
        lower, upper = 0, x
        last = None

        while True:
            mid = (upper + lower) // 2
            if last and last == mid:
                return mid
            
            squared = mid * mid

            if squared == x:
                return mid
            elif squared > x:
                upper = mid
            else:
                lower = mid

            last = mid

    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.mySqrt(4), 2)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.mySqrt(8), 2)

    def test_example3(self):
        solution = Solution()
        self.assertEqual(solution.mySqrt(0), 0)

    def test_example4(self):
        solution = Solution()
        self.assertEqual(solution.mySqrt(1), 1)

    def test_example5(self):
        solution = Solution()
        self.assertEqual(solution.mySqrt(2), 1)

if __name__ == '__main__':
    unittest.main()