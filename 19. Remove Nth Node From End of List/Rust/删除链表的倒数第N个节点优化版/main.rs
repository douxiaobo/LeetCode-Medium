// Definition for singly-linked list.
// #[derive(PartialEq, Eq, Clone, Debug)]
// pub struct ListNode {
//   pub val: i32,
//   pub next: Option<Box<ListNode>>
// }
// 
// impl ListNode {
//   #[inline]
//   fn new(val: i32) -> Self {
//     ListNode {
//       next: None,
//       val
//     }
//   }
// }
impl Solution {
    pub fn remove_nth_from_end(head: Option<Box<ListNode>>, n: i32) -> Option<Box<ListNode>> {
        let mut dummy=Some(Box::new(ListNode{val:0,next:head}));
        let mut slow_p = &mut dummy;            //慢指针
        let mut fast_p = &mut slow_p.clone();   //快指针

        //fast_p向后移动n+1个节点，以使得fast_p与slow_p之间间隔n个节点
        for _ in 1..=n+1{
            fast_p= &mut fast_p.as_mut().unwrap().next;
        }

        //遍历链表，分别向后移动fast_p和slow_p，直到past_p指向None
        while fast_p.is_some(){
            fast_p = &mut fast_p.as_mut().unwrap().next;
            slow_p = &mut slow_p.as_mut().unwrap().next;
        }

        //将slow_p指向的节点的next指针设置为指向下下个节点
        let next= &slow_p.as_mut().unwrap().next.as_mut().unwrap().next;
        slow_p.as_mut().unwrap().next=next.clone();

        dummy.unwrap().next
    }
}