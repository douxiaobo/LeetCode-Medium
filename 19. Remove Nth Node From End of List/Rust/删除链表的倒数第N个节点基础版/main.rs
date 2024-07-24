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
        let mut cur=&mut dummy;
        let mut length=0;

        //遍历链表，获得链表的长度
        while let Some(node)=cur.as_mut(){
            cur=&mut node.next;
            if let Some(_node)=cur{ length+=1; }
        }

        //设置指向哑节点的指针
        let mut new_cur=dummy.as_mut();

        //遍历链表，将指针移动至L-n个节点位置
        let idx=length-n;
        for _ in 0..idx{
            new_cur=new_cur.unwrap().next.as_mut();
        }

        //将第L-n个节点的next指针设置为指向第L-n+2个节点
        let next=new_cur.as_mut().unwrap().next.as_mut().unwrap().next.take();
        new_cur.as_mut().unwrap().next=next;

        dummy.unwrap().next
    }
}