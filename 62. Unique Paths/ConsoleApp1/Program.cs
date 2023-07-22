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
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                dp[0, j] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }//Runtime：12 ms Beats:99.87% Memory:26.6 MB Beats:77.62%
        public int UniquePaths1(int m, int n)
        {
            int[] dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
            }
            for (int j = 1; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    dp[i] += dp[i - 1];
                }
            }
            return dp[n - 1];
        }//Runtime 28 ms Beats：44.63% Memory：26.7 MB Beats：40.36%
        public int UniquePaths2(int m, int n)       //组合数学C^{m-1}_{m+n-2}
        {
            long numerator = 1;     //分子
            int denominator = m - 1;    //分母
            int count = m - 1;
            int t = m + n - 2;
            while ((count--) > 0)
            {
                numerator *= (t--);
                while (denominator != 0 && numerator % denominator == 0)
                {
                    numerator /= denominator;
                    denominator--;
                }
            }
            return (int)numerator;
        }//Runtime:29 ms Beats：39.33% Memory：26.5 MB Beats：77.62%
    }
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            int[][] dp = new int[m][];
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }
            return helper(m - 1, n - 1, dp);
        }
        private int helper(int i, int j, int[][] dp)
        {
            if (dp[i][j] == 0)
            {
                if (i == 0 || j == 0)
                {
                    dp[i][j] = 1;
                }
                else
                {
                    dp[i][j] = helper(i - 1, j, dp) + helper(i, j - 1, dp);
                }
            }
            return dp[i][j];
        }
    }//Runtime:17 ms Beats:97.54% Memory:26.5 MB Beats:88.81%
    public class Solution1
    {
        public int UniquePaths(int m, int n)
        {
            int[][] dp = new int[m][];
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }
            for (int i = 0; i < m; i++)
            {
                dp[i][0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                dp[0][i] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i][j] = dp[i][j - 1] + dp[i - 1][j];
                }
            }
            return dp[m - 1][n - 1];
        }
    }//Runtime:26 ms Beats:62.48% Memory:26.4 MB Beats:99.18%
}
