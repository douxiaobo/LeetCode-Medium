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
        public int MinPathSum(int[][] grid)
        {
            int[][] dp = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                dp[i] = new int[grid[0].Length];
            }
            dp[0][0] = grid[0][0];
            for (int j = 1; j < grid[0].Length; j++)
            {
                dp[0][j] = grid[0][j] + dp[0][j - 1];
            }
            for (int i = 1; i < grid.Length; i++)
            {
                dp[i][0] = grid[i][0] + dp[i - 1][0];
                for (int j = 1; j < grid[0].Length; j++)
                {
                    int prev = Math.Min(dp[i - 1][j], dp[i][j - 1]);
                    dp[i][j] = grid[i][j] + prev;
                }
            }
            return dp[grid.Length - 1][grid[0].Length - 1];
        }
    }//Runtime:109 ms Beats:11.14% Memory:40.9 MB Beats:29.91%
    public class Solution1
    {
        public int MinPathSum(int[][] grid)
        {
            int[] dp = new int[grid[0].Length];
            dp[0] = grid[0][0];
            for (int j = 1; j < grid[0].Length; j++)
            {
                dp[j] = grid[0][j] + dp[j - 1];
            }
            for (int i = 1; i < grid.Length; i++)
            {
                dp[0] += grid[i][0];
                for (int j = 1; j < grid[0].Length; j++)
                {
                    dp[j] = grid[i][j] + Math.Min(dp[j], dp[j - 1]);
                }
            }
            return dp[grid[0].Length - 1];
        }
    }//Runtime:110 ms Beats:9.97% Memory:40.4 MB Beats:88.27%
}
