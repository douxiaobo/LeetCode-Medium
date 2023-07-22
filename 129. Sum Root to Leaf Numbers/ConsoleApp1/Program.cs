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
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
        }
        public int SumNumbers(TreeNode root)
        {
            return dfs(root, 0);
        }
        private int dfs(TreeNode root, int path)
        {
            if (root == null)
            {
                return 0;
            }
            path = path * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                return path;
            }
            return dfs(root.left, path) + dfs(root.right, path);
        }//Runtime:79 ms Beats:93.38% Memory:38.3 MB Beats:72.6%
    }
}
