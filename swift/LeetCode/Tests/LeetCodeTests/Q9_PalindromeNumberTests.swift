import Testing
@testable import LeetCode;

class Q9_TwoSumTests {
    @Test
    public func example1() {
        let s = Q9.Solution();
        #expect(s.isPalindrome(121) == true)
    }

    @Test
    public func example2() {
        let s = Q9.Solution();
        #expect(s.isPalindrome(-121) == false)
    }

    @Test
    public func example3() {
        let s = Q9.Solution();
        #expect(s.isPalindrome(10) == false)
    }
}
