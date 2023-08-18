use std::option::Option;
use std::boxed::Box;

#[derive(PartialEq, Eq, Clone, Debug)]
pub struct ListNode {
  pub val: i32,
  pub next: Option<Box<ListNode>>
}

/*
impl ListNode {
  #[inline]
  fn new(val: i32) -> Self {
    ListNode {
      next: None,
      val
    }
  }
}*/

pub fn reverse_list(head: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
    let mut new_head: Option<Box<ListNode>> = None;
    let mut front = head;

    while let Some(node) = front {
        let after = node.next;

        new_head = Some(Box::new(ListNode {
            val: (*node).val,
            next: new_head
        }));

        front = after;
    }

    new_head
}

fn main() 
{
    let list = Some(Box::new(ListNode{
        val: 1, 
        next: Some(Box::new(ListNode{
            val: 2, 
            next: Some(Box::new(ListNode{
                val: 3, 
                next: None
            }))
        }))
    }));

    reverse_list(list);
}