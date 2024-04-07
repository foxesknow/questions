 //Definition for singly-linked list.
 #[derive(PartialEq, Eq, Clone, Debug)]
 pub struct ListNode {
   pub val: i32,
   pub next: Option<Box<ListNode>>
}
 
impl ListNode {
  #[inline]
  fn new(val: i32) -> Self {
    ListNode {
      next: None,
      val
    }
  }
}

pub fn add_two_numbers(l1: Option<Box<ListNode>>, l2: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
    pub fn recurse(l1: Option<Box<ListNode>>, l2: Option<Box<ListNode>>, carry: i32) -> Option<Box<ListNode>> {
        match (l1, l2) {
            (Some(x), Some(y)) => {
                let total = x.val + y.val + carry;
                return Some(Box::new(ListNode{val: total % 10, next: recurse(x.next, y.next, total / 10)}))
            }
            (Some(x), None) => {
                let total = x.val + carry;
                return Some(Box::new(ListNode{val: total % 10, next: recurse(x.next, None, total / 10)}))
            }
            (None, Some(y)) => {
                let total = y.val + carry;
                return Some(Box::new(ListNode{val: total % 10, next: recurse(None, y.next, total / 10)}))
            }

            (None, None) => {
                if carry == 0 {
                    None
                } else {
                    Some(Box::new(ListNode{val: carry, next: None}))
                }
            }
        }
    }

    recurse(l1, l2, 0)
}

fn main() {
    let list1 = Some(Box::new(ListNode{
        val: 1, 
        next: Some(Box::new(ListNode{
            val: 2, 
            next: Some(Box::new(ListNode{
                val: 3, 
                next: None
            }))
        }))
    }));

    let list2 = Some(Box::new(ListNode{
        val: 1, 
        next: Some(Box::new(ListNode{
            val: 2, 
            next: Some(Box::new(ListNode{
                val: 3, 
                next: None
            }))
        }))
    }));

    let result = add_two_numbers(list1, list2);
}