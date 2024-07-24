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
impl Solution {
    pub fn insert_into_bst(root: Option<Rc<RefCell<TreeNode>>>, val: i32) -> Option<Rc<RefCell<TreeNode>>> {
        //如果根节点为空，直接返回由插入值创建的节点
        if root.is_none() {
            return Some(Rc::new(RefCell::new(TreeNode::new(val))));
        }
        insert(&root,val);
        root
    }
}

fn insert(root: &Option<Rc<RefCell<TreeNode>>>, val:i32) {
    if let Some(node)=root {
        let mut n=node.borrow_mut();
        
        //val大于当前节点值，往右子树查找
        //val小于当前节点值，往左子树查找
        let target=if val>n.val { &mut n.right} else { &mut n.left};
        if target.is_some() {
            return insert(target,val);
        }

        //在找到的空节点位置插入
        *target=Some(Rc::new(RefCell::new(TreeNode::new(val))));
    }
}