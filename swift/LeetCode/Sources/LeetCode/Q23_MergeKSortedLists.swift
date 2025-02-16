enum Q23 {
    class Solution {
        func mergeKLists(_ lists: [ListNode?]) -> ListNode? {
            if lists.count == 0 {return nil}
            
            var head: ListNode? = nil;

            for node in lists {
                head = mergeTwoLists(head, node)
            }

            return head
        }

        func mergeTwoLists(_ list1: ListNode?, _ list2: ListNode?) -> ListNode? {
            if list1 == nil {return list2}
            if list2 == nil {return list1}

            var l1 = list1
            var l2 = list2

            let head = next(&l1, &l2)
            var tail = head

            while l1 != nil && l2 != nil {
                let smallest = next(&l1, &l2)
                tail.next = smallest
                tail = smallest
            }

            tail.next = (l1 != nil ? l1 : l2)

            return head
        }

        func next(_ list1: inout ListNode?, _ list2: inout ListNode?) -> ListNode {
            if list1!.val < list2!.val {
                let node = list1
                list1 = list1!.next

                return node!
            } else {
                let node = list2
                list2 = list2!.next

                return node!
            }
        }
    }
}
