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
            public TreeNode(int val = 0,TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right=right;
            }
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(3);
            root.right = new TreeNode(2);
            root.left.left= new TreeNode(5);
            root.left.right = new TreeNode(3);
            root.right.right = new TreeNode(9);
            Console.WriteLine(LargestValues(root));
            Console.ReadKey();
        }
        public static IList<int> LargestValues(TreeNode root)
        {
            int current = 0;
            int next = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root);
                current = 1;
            }
            List<int> result = new List<int>();
            int max = Int32.MinValue;
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                current--;
                max = Math.Max(max, node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    next++;
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    next++;
                }
                if (current == 0)
                {
                    result.Add(max);
                    max = Int32.MinValue;
                    current = next;
                    next = 0;
                }
            }
            return result;
        }//Runtime:149 ms Beats:47.62% Memory:45 MB Beats:61.90%
        public IList<int> LargestValues2(TreeNode root)
        {
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            if (root != null)
            {
                queue1.Enqueue(root);
            }
            List<int> result = new List<int>();
            int max = Int32.MinValue;
            while (queue1.Count > 0)
            {
                TreeNode node = queue1.Dequeue();
                max = Math.Max(max, node.val);
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
                    result.Add(max);
                    max = Int32.MinValue;
                    queue1 = new Queue<TreeNode>(queue2.ToList());
                    queue2 = new Queue<TreeNode>();
                }
            }
            return result;
        }//Runtime:146 ms Beats:65.48% Memory:46.7 MB Beats:5.95%
    }
}
