﻿namespace console2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root==null) {
            return new TreeNode(val);
        }
        if(root.val>val){
            if(root.left!=null){
                root.left=InsertIntoBST(root.left,val);
            } else {
                root.left=new TreeNode(val);
            }
        } else {
            if(root.right!=null){
                root.right=InsertIntoBST(root.right,val);
            } else {
                root.right=new TreeNode(val);
            }
        }
        return root;
    }
}