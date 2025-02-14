enum Q9 {
    class Solution {
        func isPalindrome(_ x: Int) -> Bool {
            if x < 0 {
                return false
            }

            if x == Int.min {
                return false
            }

            var value = x
            var current = 0

            while value != 0 {
                current = (current * 10) + (value % 10)
                value /= 10
            }

            return current == x
        }
    }
}
