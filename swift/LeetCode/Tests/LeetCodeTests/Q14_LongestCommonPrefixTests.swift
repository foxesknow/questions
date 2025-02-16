import Testing
@testable import LeetCode;

class Q14_LongestCommonPrefixTests {
    @Test
    public func example1() {
        let s = Q14.Solution();

        #expect(s.longestCommonPrefix(["flower", "flow", "flight"]) == "fl")
    }

    @Test
    public func example2() {
        let s = Q14.Solution();

        #expect(s.longestCommonPrefix(["dog", "racecar", "car"]) == "")
    }
}