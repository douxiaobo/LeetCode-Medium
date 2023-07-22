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
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            if (obstacleGrid[m - 1][n - 1] == 1 || obstacleGrid[0][0] == 1)
            {
                return 0;
            }
            int[,] dp = new int[m, n];
            for (int i = 0; i < m && obstacleGrid[i][0] == 0; i++)
            {
                dp[i, 0] = 1;
            }
            for (int j = 0; j < n && obstacleGrid[0][j] == 0; j++)
            {
                dp[0, j] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        continue;
                    }
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
