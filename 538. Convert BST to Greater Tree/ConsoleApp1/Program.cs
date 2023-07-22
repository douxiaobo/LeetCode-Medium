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
            this.left = left;
            this.right = right;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            int sum = 0;
            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.right;
                }
                cur = stack.Pop();
                sum += cur.val;
                cur.val = sum;
                cur = cur.left;
            }
            return root;
        }
    }//Runtime:112 ms Beats:14% Memory:45.2 MB Beats:20%
}
