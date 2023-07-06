from typing import List
import random
import unittest

class Solution:

    def __init__(self, nums: List[int]):
        self.original_numbers = nums
        self.seed = 2166136261
        

    def reset(self) -> List[int]:
        return self.original_numbers
        

    def shuffle(self) -> List[int]:
        r = random.Random(self.seed)
        self.seed += 16777619

        pack = self.original_numbers.copy()
        r.shuffle(pack)

        return pack

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution([-6,10,184])
        print(solution.reset())
        print(solution.shuffle())
        print(solution.reset())
        print(solution.shuffle())
        print(solution.reset())
        print(solution.shuffle())


if __name__ == '__main__':
    unittest.main()