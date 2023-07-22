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
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int size = triangle.Count;
            int[][] dp = new int[size][];
            for (int i = 0; i < size; i++)
            {
                dp[i] = new int[size];
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    dp[i][j] = triangle[i][j];
                    if (i > 0 && j == 0)
                    {
                        dp[i][j] += dp[i - 1][j];
                    }
                    else if (i > 0 && i == j)
                    {
                        dp[i][j] += dp[i - 1][j - 1];
                    }
                    else if (i > 0)
                    {
                        dp[i][j] += Math.Min(dp[i - 1][j], dp[i - 1][j - 1]);
                    }
                }
            }
            int min = Int32.MaxValue;
            foreach (int num in dp[size - 1])
            {
                min = Math.Min(min, num);
            }
            return min;
        }
    }//Runtime:108 ms Beats:31.41% Memory:40.2 MB Beats:28.88%
    public class Solution1
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int[] dp = new int[triangle.Count];
            foreach (List<int> row in triangle)
            {
                for (int j = row.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        dp[j] += row[j];
                    }
                    else if (j == row.Count - 1)
                    {
                        dp[j] = dp[j - 1] + row[j];
                    }
                    else
                    {
                        dp[j] = Math.Min(dp[j], dp[j - 1]) + row[j];
                    }
                }
            }
            int min = Int32.MaxValue;
            foreach (int num in dp)
            {
                min = Math.Min(min, num);
            }
            return min;
        }
    }//Runtime:104 ms Beats:49.46% Memory:40 MB Beats:41.52%
}
