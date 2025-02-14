public class ListNode {
    public var val: Int
    public var next: ListNode?

    public init() {
        self.val = 0
        self.next = nil
    }
    public init(_ val: Int) {
        self.val = val
        self.next = nil
    }
    public init(_ val: Int, _ next: ListNode?) {
        self.val = val
        self.next = next
    }

    public func flatten() -> [Int] {
        var values: [Int] = []

        var node: ListNode? = self;
        while node != nil {
            values.append(node!.val)
            node = node?.next
        }

        return values
    }

    public static func makeList(_ numbers: Int...) -> ListNode? {
        var head: ListNode? = nil

        for num in numbers.reversed() {
            head = ListNode(num, head)
        }

        return head
    }
}
