namespace C_;

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
    int sum=0;
    public TreeNode BstToGst(TreeNode root) {
        if(root!=null){
            BstToGst(root.right);
            sum+=root.val;
            root.val=sum;
            BstToGst(root.left);
        }
        return root;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


// dotnet new console --framework net8.0 --use-program-main