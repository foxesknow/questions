import Testing
@testable import LeetCode;

class Q21_MergeTwoSortedListsTests {
    @Test
    public func example1() {
        let s = Q21.Solution();
        
        let list1 = ListNode.makeList(1, 2, 4)
        let list2 = ListNode.makeList(1, 3, 4)

        let result = s.mergeTwoLists(list1, list2)
        #expect(result!.flatten() == [1, 1, 2, 3, 4, 4])
    }

    @Test
    public func example2() {
        let s = Q21.Solution();
        
        let list1: ListNode? = nil
        let list2: ListNode? = nil

        let result = s.mergeTwoLists(list1, list2)
        #expect(result == nil)
    }

    @Test
    public func example3() {
        let s = Q21.Solution();
        
        let list1: ListNode? = nil
        let list2 = ListNode.makeList(1)

        let result = s.mergeTwoLists(list1, list2)
        #expect(result!.flatten() == [1])
    }
}
