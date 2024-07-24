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
            Console.WriteLine(IntegerBreak(10));
            Console.ReadKey();
        }
        public static int IntegerBreak(int n)
        {
            int[] dp = new int[n + 1];
            dp[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                for (int j = 1; j <= i / 2; j++)
                {
                    dp[i] = Math.Max(dp[i], Math.Max((i - j) * j, dp[i - j] * j));
                }
            }
            return dp[n];
        }//Runtime：15 ms Beats：98.99% Memory:26.2 MB Beats:96.97%
        public int IntegerBreak1(int n)
        {
            if (n == 2)
            {
                return 1;
            }
            if (n == 3)
            {
                return 2;
            }
            if (n == 4)
            {
                return 4;
            }
            int result = 1;
            while (n > 4)
            {
                result *= 3;
                n -= 3;
            }
            result *= n;
            return result;
        }//Runtime：20 ms Beats：88.89% Memory：26.4 MB Beats：76.77%
    }
}
