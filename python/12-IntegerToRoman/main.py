import unittest

class Solution:
    def intToRoman(self, num: int) -> str:
        numeral = ""

        while num >= 1000:
            numeral += "M"
            num -= 1000

#####################################
        if num >= 900:
            numeral += "CM"
            num -= 900

        if num >= 500:
            numeral += "D"
            num -= 500

            while num >= 100:
                numeral += "C"
                num -= 100

#####################################
        if num >= 400:
            numeral += "CD"
            num -= 400

        while num >= 100:
            numeral += "C"
            num -= 100

#####################################
        if num >= 90:
            numeral += "XC"
            num -= 90

        while num >= 50:
            numeral += "L"
            num -= 50

#####################################
        if num >= 40:
            numeral += "XL"
            num -= 40

        while num >= 10:
            numeral += "X"
            num -= 10

#####################################
        if num >= 9:
            numeral += "IX"
            num -= 9
        
        while num >= 5:
            numeral += "V"
            num -= 5

#####################################
        if num >= 4:
            numeral += "IV"
            num -= 4

        while num >= 1:
            numeral += "I"
            num -= 1

        return numeral

class Tests(unittest.TestCase):
    def test_thousands(self):
        solution = Solution()

        params = [(1000, "M"), (2000, "MM"), (3000, "MMM")]
        for number, numeral in params:
            with self.subTest():
                self.assertTrue(solution.intToRoman(number) == numeral, numeral)

    def test_above_1000(self):
        solution = Solution()

        params = [(1500, "MD"), (1600, "MDC"), (1700, "MDCC"), (1800, "MDCCC"), (1900, "MCM")]
        for number, numeral in params:
            with self.subTest():
                self.assertTrue(solution.intToRoman(number) == numeral, numeral)

    def test_above_500(self):
        solution = Solution()

        params = [(500, "D"), (600, "DC"), (700, "DCC"), (800, "DCCC"), (900, "CM")]
        for number, numeral in params:
            with self.subTest():
                self.assertTrue(solution.intToRoman(number) == numeral, numeral)

    def test_above_100(self):
        solution = Solution()

        params = [(100, "C"), (200, "CC"), (300, "CCC"), (400, "CD")]
        for number, numeral in params:
            with self.subTest():
                self.assertTrue(solution.intToRoman(number) == numeral, numeral)

    def test_above_50(self):
        solution = Solution()

        params = [(50, "L"), (60, "LX"), (70, "LXX"), (80, "LXXX"), (90, "XC")]
        for number, numeral in params:
            with self.subTest():
                self.assertTrue(solution.intToRoman(number) == numeral, numeral)

    def test_example1(self):
        solution = Solution()
        self.assertTrue(solution.intToRoman(3) == "III")

    def test_example2(self):
        solution = Solution()
        self.assertTrue(solution.intToRoman(58) == "LVIII")

    def test_example3(self):
        solution = Solution()
        self.assertTrue(solution.intToRoman(1994) == "MCMXCIV")



if __name__ == '__main__':
    unittest.main()