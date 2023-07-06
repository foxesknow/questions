from typing import List
import unittest

class Solution:
    def validUtf8(self, data: List[int]) -> bool:
        def check_following(index: int) -> bool:
            if index < len(data):
                return data[index] & 0b11000000 == 0b10000000
            else:
                return False

        b1_mask = 0b10000000
        b2_mask = 0b11100000
        b3_mask = 0b11110000
        b4_mask = 0b11111000

        i = 0

        while i < len(data):
            b = data[i]
            if b & b1_mask == 0:
                i += 1
            elif b & b2_mask == 0b11000000:
                if not check_following(i + 1): return False
                i += 2
            elif b & b3_mask == 0b11100000:
                if not check_following(i + 1): return False
                if not check_following(i + 2): return False
                i += 3
            elif b & b4_mask == 0b11110000:
                if not check_following(i + 1): return False
                if not check_following(i + 2): return False
                if not check_following(i + 3): return False
                i += 4
            else:
                return False
            
        return True
    
class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.validUtf8([197,130,1]))

    def test_example2(self):
        solution = Solution()
        self.assertFalse(solution.validUtf8([235,140,4]))
        

if __name__ == '__main__':
    unittest.main()