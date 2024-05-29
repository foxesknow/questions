
class ListNode {
    val: number
    next: ListNode | null
    constructor(val?: number, next?: ListNode | null) {
        this.val = (val === undefined ? 0 : val)
        this.next = (next === undefined ? null : next)
    }
}


function addTwoNumbers(l1: ListNode | null, l2: ListNode | null): ListNode | null {
    let carry = 0;

    let head : ListNode = null;
    let tail : ListNode = null;

    while (l1 != null || l2 != null || carry != 0) {
        let sum = carry;

        if (l1 != null) {
            sum += l1.val;
            l1 = l1.next;
        }

        if (l2 != null) {
            sum += l2.val;
            l2 = l2.next;
        }

        let node = new ListNode(sum % 10);
        carry = Math.trunc(sum / 10);

        if (tail == null) {
            head = tail = node;
        } else {
            tail.next = node;
            tail = node;
        }
    }

    return head;
};

test("example 1", () => {
    let l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    let l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
    
    let result = addTwoNumbers(l1, l2);
    expect(result.val).toBe(7);
    expect(result.next.val).toBe(0);
    expect(result.next.next.val).toBe(8);
});

test("example 2", () => {
    let l1 = new ListNode(0);
    let l2 = new ListNode(0);
    
    let result = addTwoNumbers(l1, l2);
    expect(result.val).toBe(0);
    expect(result.next).toBe(null);
});

test("example 4", () => {
    let l1 = new ListNode(9);
    let l2 = new ListNode(7);
    
    let result = addTwoNumbers(l1, l2);
    expect(result.val).toBe(6);
    expect(result.next.val).toBe(1);
});