import Testing

@testable import LeetCode

class Q2_AddTwoNumbersTests {
    @Test
    public func example1() {
        let s = Q2.Solution()

        let l1 = ListNode.makeList(2, 4, 3)
        let l2 = ListNode.makeList(5, 6, 4)

        let result = s.addTwoNumbers(l1, l2)
        #expect(result != nil)

        let flattened = result?.flatten()
        #expect(flattened == [7, 0, 8])
    }

    @Test
    public func example2() {
        let s = Q2.Solution()

        let l1 = ListNode.makeList(0)
        let l2 = ListNode.makeList(0)

        let result = s.addTwoNumbers(l1, l2)
        #expect(result != nil)

        let flattened = result?.flatten()
        #expect(flattened == [0])
    }

    @Test
    public func example3() {
        let s = Q2.Solution()

        let l1 = ListNode.makeList(9, 9, 9, 9, 9, 9, 9)
        let l2 = ListNode.makeList(9, 9, 9, 9)

        let result = s.addTwoNumbers(l1, l2)
        #expect(result != nil)

        let flattened = result?.flatten()
        #expect(flattened == [8, 9, 9, 9, 0, 0, 0, 1])
    }
}
