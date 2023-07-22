using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class CBTInserter
    {
        private Queue<TreeNode> queue;
        private TreeNode root;

        public CBTInserter(TreeNode root)
        {
            this.root = root;
            queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Peek().left != null && queue.Peek().right != null)
            {
                TreeNode node = queue.Dequeue();
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }

        public int Insert(int val)
        {
            TreeNode parent = queue.Peek();
            TreeNode node = new TreeNode(val);
            if (parent.left == null)
            {
                parent.left = node;
            }
            else
            {
                parent.right = node;
                queue.Dequeue();
                queue.Enqueue(parent.left);
                queue.Enqueue(parent.right);
            }
            return parent.val;
        }

        public TreeNode Get_root()
        {
            return this.root;
        }
    }
}
