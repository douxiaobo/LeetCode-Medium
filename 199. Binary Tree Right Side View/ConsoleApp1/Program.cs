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
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(1);
            node.left= new TreeNode(2);
            node.left.right= new TreeNode(5);
            node.right= new TreeNode(3);
            node.right.right = new TreeNode(4);
            List<int> res = new List<int>(RightSideView(node));
            foreach(int i in res)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static IList<int> RightSideView(TreeNode root)
        {
            List<int> view = new List<int>();
            if (root == null)
            {
                return view;
            }
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(root);
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
                    view.Add(node.val);
                    queue1 = new Queue<TreeNode>(queue2.ToList());
                    queue2 = new Queue<TreeNode>();
                }
            }
            return view;
        }
    }
}
