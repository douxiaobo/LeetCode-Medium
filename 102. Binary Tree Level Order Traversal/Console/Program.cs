namespace Console;

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> levels=new List<IList<int>>();
        if(root==null){
            return levels;
        }
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0){
            List<int> current_level=new List<int>();
            int level_length=queue.Count;
            for(int i=0;i<level_length;i++){
                TreeNode cur=queue.Dequeue();
                if(cur!=null){
                    current_level.Add(cur.val);
                }
                if(cur.left!=null){
                    queue.Enqueue(cur.left);
                }
                if(cur.right!=null){
                    queue.Enqueue(cur.right);
                }
            }
            levels.Add(current_level);
        }
        return levels;
    }
}