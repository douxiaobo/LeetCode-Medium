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
        List<List<int>> result;
        List<int> path;
        void backtracking(int targetSum, int k, int sum, int startIndex)
        {
            if (path.Count == k)
            {
                if (sum == targetSum) result.Add(new List<int>(path));
                return;
            }
            for (int i = startIndex; i <= 9; i++)
            {
                sum += i;
                path.Add(i);
                backtracking(targetSum, k, sum, i + 1);
                sum -= i;
                path.RemoveAt(path.Count - 1);
            }
        }
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            result = new List<List<int>>();
            path = new List<int>();
            backtracking(n, k, 0, 1);
            return result.ToArray();
        }
    }//Runtime:81 ms Beats:98.8% Memory:36.4 MB Beats:49.81%
}
