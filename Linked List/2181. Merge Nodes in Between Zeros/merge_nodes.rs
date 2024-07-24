// 定义单链表结构体
#[derive(PartialEq, Eq, Clone, Debug)]
pub struct ListNode {
    pub val: i32,
    pub next: Option<Box<ListNode>>,
}

impl ListNode {
    // 构造函数
    #[inline]
    pub fn new(val: i32) -> Self {
        ListNode { 
            next: None, 
            val 
        }
    }
}

pub fn merge_nodes(head: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
    let mut current_head = head; // 创建一个新的可变变量来持有head的值
    let mut dummy_head = Box::new(ListNode::new(0));
    let mut current = &mut dummy_head;
    let mut sum = 0;

    while let Some(node) = current_head {
        if node.val > 0 {
            sum += node.val;
        } else if sum != 0 {
            current.next = Some(Box::new(ListNode::new(sum)));
            current = current.next.as_mut().unwrap();
            sum = 0;
        }
        current_head = node.next; // 修改的是current_head而不是head
    }

    dummy_head.next
}

fn main() {
    // 创建链表 [0,1,0,3,0,2,2,0]
    let mut head = Some(Box::new(ListNode::new(0)));
    let mut current = head.as_mut().unwrap();
    
    let values = vec![1, 0, 3, 0, 2, 2, 0];
    for &val in values.iter() {
        current.next = Some(Box::new(ListNode::new(val)));
        current = current.next.as_mut().unwrap();
    }

    // 调用merge_nodes函数
    let merged_head = merge_nodes(head);

    // 打印合并后的链表
    let mut current = merged_head;
    while let Some(node) = current {
        print!("{} ", node.val);
        current = node.next;
    }
    println!("");
}