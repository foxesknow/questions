import Testing
@testable import LeetCode;

class Q23_MergeKSortedListsTests {
    @Test
    public func example1() {
        let s = Q23.Solution();
        
        let lists = [
            ListNode.makeList(1, 4, 5),
            ListNode.makeList(1, 3, 4),
            ListNode.makeList(2, 6),
        ]

        let result = s.mergeKLists(lists)
        #expect(result!.flatten() == [1, 1, 2, 3, 4, 4, 5, 6])
    }

    @Test
    public func example2() {
        let s = Q23.Solution();

        let result = s.mergeKLists([])
        #expect(result == nil)
    }
}
