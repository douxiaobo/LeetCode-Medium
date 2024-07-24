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
            public TreeNode(int val=0, TreeNode left=null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
        }
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if (root.left == null && root.right == null && root.val == 0)
            {
                return null;
            }
            return root;
        }//Runtime:73 ms Beats:97.6% Memory:38.1 MB Beats:38.24%
    }
}
