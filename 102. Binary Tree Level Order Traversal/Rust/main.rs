// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//   pub val: i32,
//   pub left: Option<Rc<RefCell<TreeNode>>>,
//   pub right: Option<Rc<RefCell<TreeNode>>>,
// }
// 
// impl TreeNode {
//   #[inline]
//   pub fn new(val: i32) -> Self {
//     TreeNode {
//       val,
//       left: None,
//       right: None
//     }
//   }
// }
use std::rc::Rc;
use std::cell::RefCell;
use std::collections::VecDeque;
impl Solution {
    pub fn level_order(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<Vec<i32>> {
        let mut levels: Vec<Vec<i32>>=vec![];
        if root.is_none() { return levels;}

        let mut deque: VecDeque<Option<Rc<RefCell<TreeNode>>>>=VecDeque::new();
        deque.push_back(root);

        while !deque.is_empty() {
            //开始当前层
            let mut current_level=vec![];

            //当前层中的元素个数
            let level_length=deque.len();
            for _ in 0..level_length {
                let n=deque.pop_front();
                if let Some(Some(node))=n{
                    //添加当前节点
                    current_level.push(node.borrow().val);

                    //将当前节点的左、右子节点加入队列
                    if node.borrow().left.is_some() {
                        deque.push_back(node.borrow().left.clone());
                    }

                    if node.borrow().right.is_some() {
                        deque.push_back(node.borrow().right.clone());
                    }
                }
            }
            levels.push(current_level);
        }
        levels
    }
}