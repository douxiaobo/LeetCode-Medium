namespace console1;

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
        root=insert(root,val);
        return root;
    }
    public TreeNode insert(TreeNode root, int val) {
        if(root.val>val){
            if(root.left!=null){
                root.left=insert(root.left,val);
            } else {
                root.left=new TreeNode(val);
            }
        } else {
            if(root.right!=null){
                root.right=insert(root.right,val);
            } else {
                root.right=new TreeNode(val);
            }
        }
        return root;
    }
}