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
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                result += Math.Max(prices[i] - prices[i - 1], 0);
            }
            return result;
        }//Runtime:77 ms Beats:96.48% Memory:39.6 MB Beats:39.4%
        public int MaxProfit1(int[] prices)
        {
            // dp[i][1]第i天持有的最多现金
            // dp[i][0]第i天持有股票后的最多现金
            int[,] dp = new int[prices.Length, 2];
            dp[0, 0] -= prices[0];  // 持股票
            for (int i = 1; i < prices.Length; i++)
            {
                // 第i天持股票所剩最多现金 = max(第i-1天持股票所剩现金, 第i-1天持现金-买第i天的股票)
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] - prices[i]);
                // 第i天持有最多现金 = max(第i-1天持有的最多现金，第i-1天持有股票的最多现金+第i天卖出股票)
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] + prices[i]);
            }
            return Math.Max(dp[prices.Length - 1, 0], dp[prices.Length - 1, 1]);
        }//Runtime:100 ms Beats:12.80% Memory:40 MB Beats:5.12%
    }
}
