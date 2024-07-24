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
    public class Solution
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> path = new List<int>();
        public IList<IList<int>> Combine(int n, int k)
        {
            backtracking(n, k, 1);
            return result;
        }
        void backtracking(int n, int k, int startIndex)
        {
            if (path.Count == k)
            {
                result.Add(new List<int>(path));
                return;
            }
            for (int i = startIndex; i <= n; i++)
            {
                path.Add(i);
                backtracking(n, k, i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }//Runtime:134 ms Beats:24.27% Memory:43.9 MB Beats:97.49%
    public class Solution1
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> path = new List<int>();
        public IList<IList<int>> Combine(int n, int k)
        {
            backtracking(n, k, 1);
            return result;
        }
        void backtracking(int n, int k, int startIndex)
        {
            if (path.Count == k)
            {
                result.Add(new List<int>(path));
                return;
            }
            for (int i = startIndex; i <= n - (k - path.Count) + 1; i++)
            {
                path.Add(i);
                backtracking(n, k, i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }//Runtime:107 ms Beats:90.80% Memory:44.2 MB Beats:76.99%
}
