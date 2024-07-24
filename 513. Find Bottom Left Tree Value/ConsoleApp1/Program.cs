using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0,TreeNode left=null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);
            root.right.left.left = new TreeNode(7);
            Console.WriteLine(FindBottomLeftValue(root));
            Console.ReadKey();
        }
        public static int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(root);
            int bottomLeft = root.val;
            while (queue1.Count > 0)
            {
                TreeNode node = queue1.Dequeue();
                if (node.left != null)
                {
                    queue2.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue2.Enqueue(node.right);
                }
                if (queue1.Count == 0)
                {
                    queue1 = new Queue<TreeNode>(queue2.ToList());
                    queue2 = new Queue<TreeNode>();
                    if (queue1.Count > 0)
                    {
                        bottomLeft = queue1.Peek().val;
                    }
                }
            }
            return bottomLeft;
        }//Runtime:106 ms Beats:5.88% Memory:42 MB Beats:7.35%
    }
}
