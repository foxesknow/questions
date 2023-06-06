from typing import List
import unittest

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
            cache = {}

            for index, value in enumerate(nums):
                  existing = cache.get(value, None)
                  if existing is not None:
                        return [index, existing]
                  
                  cache[target - value] = index

            return []
    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          result = solution.twoSum([2, 7, 11, 15], 9)
          self.assertIsNotNone(result)          
          self.assertTrue(len(result) == 2)          
          self.assertIn(0, result)
          self.assertIn(1, result)

    def test_example2(self):
          solution = Solution()
          result = solution.twoSum([3, 2, 4], 6)
          self.assertIsNotNone(result)          
          self.assertTrue(len(result) == 2)          
          self.assertIn(1, result)
          self.assertIn(2, result)



if __name__ == '__main__':
    unittest.main()