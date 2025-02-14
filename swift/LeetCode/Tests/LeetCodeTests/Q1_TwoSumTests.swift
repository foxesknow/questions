import Testing
@testable import LeetCode;

class Q1_TwoSumTests{
    @Test
    public func example1() {
        let s = Q1.Solution();
        #expect(s.twoSum([2,7,11,15], 9) == [0, 1])
    }

    @Test
    public func example2() {
        let s = Q1.Solution();
        #expect(s.twoSum([3, 2, 4], 6) == [1, 2])
    }
}