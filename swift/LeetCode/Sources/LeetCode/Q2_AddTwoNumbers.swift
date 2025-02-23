enum Q2 {
    class Solution {
        func addTwoNumbers(_ l1: ListNode?, _ l2: ListNode?) -> ListNode? {
            if l1 == nil {return l2}
            if l2 == nil {return l1}
            
            var left = l1
            var right = l2

            var carry = 0

            var head: ListNode? = nil
            var next: ListNode? = nil

            while left != nil || right != nil || carry != 0 {
                var sum = carry

                if let node = left {
                    sum += node.val
                    left = node.next
                }

                if let node = right {
                    sum += node.val
                    right = node.next
                }

                let node = ListNode(sum % 10)
                carry = sum / 10

                if next == nil {
                    head = node
                    next = node
                } else {
                    next?.next = node
                    next = node
                }
            }

            return head
        }
    }
}
