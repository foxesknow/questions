import Testing

@testable import LeetCode

class Q27_RemoveElementTests {
    @Test
    public func example1() {
        let s = Q27.Solution()

        var nums = [3, 2, 2, 3]
        let count = s.removeElement(&nums, 3)
        #expect(count == 2)
        #expect(nums[0..<count] == [2, 2])
    }

    @Test
    public func example2() {
        let s = Q27.Solution()

        var nums = [0, 1, 2, 2, 3, 0, 4, 2]
        let count = s.removeElement(&nums, 2)
        #expect(count == 5)

        var filtered = nums[0..<count]
        filtered.sort()
        #expect(filtered == [0, 0, 1, 3, 4])
    }
}
