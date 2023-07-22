using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0,TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left= left; 
            this.right= right;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class BSTIterator
    {
        TreeNode cur;
        Stack<TreeNode> stack;

        public BSTIterator(TreeNode root)
        {
            cur = root;
            stack = new Stack<TreeNode>();
        }

        public int Next()
        {
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }
            cur = stack.Pop();
            int val = cur.val;
            cur = cur.right;
            return val;
        }

        public bool HasNext()
        {
            return cur != null || stack.Count > 0;
        }
    }//Runtime:163 ms Beats:48.68% Memory:55.1 MB Beats:73.2%
}
