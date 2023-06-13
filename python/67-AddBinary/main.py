import unittest

class Solution:
    def addBinary(self, a: str, b: str) -> str:
        if a == "0":
            return b
        elif b == "0":
            return a
        
        max_length = max(len(a), len(b))
        sum_buffer = [0] * (max_length + 1)

        sum_buffer_next = len(sum_buffer) - 1
        a_next = len(a) - 1 
        b_next = len(b) - 1

        carry = 0
        while a_next >= 0 or b_next >= 0 or carry == 1:
            bit_a = 0 if a_next < 0 else int(a[a_next])
            bit_b = 0 if b_next < 0 else int(b[b_next])

            sum = bit_a + bit_b + carry
            sum_buffer[sum_buffer_next] = sum % 2
            carry = sum // 2

            a_next -= 1
            b_next -= 1
            sum_buffer_next -= 1

        first_non_zero_offset = 1 if sum_buffer[0] == 0 else 0
        return "".join(str(x) for x in sum_buffer[first_non_zero_offset:])

class Tests(unittest.TestCase):
    def test_example1(self):
        solution = Solution()
        self.assertEqual(solution.addBinary("11", "1"), "100")

    def test_example2(self):
        solution = Solution()
        self.assertEqual(solution.addBinary("1010", "1011"), "10101")



if __name__ == '__main__':
    unittest.main()