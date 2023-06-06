import unittest

class Solution:
    def convert(self, s: str, numRows: int) -> str:
        
        tuples = []
        for t in self.generate_tuples(s, numRows):
            tuples.append(t)

        tuples.sort(key = lambda t: (t[0], t[1]))
        return "".join(str(t[2]) for t in tuples)
    

    def generate_tuples(self, s:str, num_rows: int):
        row = 0
        column = 0
        delta = 1

        for c in s:
            yield (row, column, c)
            
            row += delta
            if row == -1:
                row = 1
                column += 1
                delta = 1
            elif row == num_rows:
                row = max(0, row - 2)
                column += 1
                delta = -1

    
class Tests(unittest.TestCase):
    def test_example1(self):
          solution = Solution()
          self.assertTrue(solution.convert("PAYPALISHIRING", 3) == "PAHNAPLSIIGYIR")

    def test_example2(self):
          solution = Solution()
          self.assertTrue(solution.convert("PAYPALISHIRING", 4) == "PINALSIGYAHRPI")

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.convert("A", 1) == "A")

    def test_example3(self):
          solution = Solution()
          self.assertTrue(solution.convert("AB", 1) == "AB")


if __name__ == '__main__':
    unittest.main()