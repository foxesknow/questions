import Testing

@testable import LeetCode

class Q26_RemoveDuplicatesTests {
    @Test func example1() {
        let s = Q26.Solution()
        var nums = [1, 1, 2]
        let count = s.removeDuplicates(&nums)

        #expect(count == 2)
        #expect(nums[0] == 1)
        #expect(nums[1] == 2)
    }

    @Test func example2() {
        let s = Q26.Solution()
        var nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
        let count = s.removeDuplicates(&nums)

        #expect(count == 5)
        #expect(nums[0] == 0)
        #expect(nums[1] == 1)
        #expect(nums[2] == 2)
        #expect(nums[3] == 3)
        #expect(nums[4] == 4)
    }
}
