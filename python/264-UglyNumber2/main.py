#
# Todo: fix speed
#
from typing import Iterator, Set
import unittest

class Solution:
    def nthUglyNumber(self, n: int) -> int:
        for x in self.ugly_numbers():
            if n == 1: return x

            n -= 1
        
        return 0
    
    def isUgly(self, n: int, hits: Set[int], misses: Set[int]) -> bool:
        if n == 1: return True
        if n < 1: return False
        
        if n in hits: return True
        if n in misses: return False

        if n % 2 == 0 and self.isUgly(n // 2, hits, misses): return True
        if n % 3 == 0 and self.isUgly(n // 3, hits, misses): return True
        if n % 5 == 0 and self.isUgly(n // 5, hits, misses): return True

        return False
    
    def ugly_numbers(self) -> Iterator[int]:
        yield 1

        hits = {1}
        misses: Set[int] = set()
        
        next = 2

        while True:
            if self.isUgly(next, hits, misses):
                yield next
                hits.add(next)
            else:
                misses.add(next)

            next += 1


class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.nthUglyNumber(10), 12)

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.nthUglyNumber(1), 1)

if __name__ == '__main__':
    unittest.main()
