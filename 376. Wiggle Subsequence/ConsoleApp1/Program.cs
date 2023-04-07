using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }
            int curDiff = 0;
            int preDiff = 0;
            int result = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                curDiff = nums[i + 1] - nums[i];
                if ((preDiff <= 0 && curDiff > 0) || (preDiff >= 0 && curDiff < 0))
                {
                    result++;
                    preDiff = curDiff;
                }
            }
            return result;
        }//Runtime:86 ms Beats:57.50% Memory:38 MB Beats:47.50%
        public int WiggleMaxLength1(int[] nums)
        {
            int[][] dp = new int[1001][];
            for (int i = 0; i < 1001; i++)
            {
                dp[i] = new int[2] { 0, 0 };
            }
            dp[0][0] = dp[0][1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i][0] = dp[i][1] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        dp[i][1] = Math.Max(dp[i][1], dp[j][0] + 1);
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i][0] = Math.Max(dp[i][0], dp[j][1] + 1);
                    }
                }
            }
            return Math.Max(dp[nums.Length - 1][0], dp[nums.Length - 1][1]);
        }//Runtime:83 ms Beats:75% Memory:39.1 MB Beats:5%
        public static int WiggleMaxLength2(int[] nums)
        {
            int[,] dp = new int[1001, 2];
            for (int i = 0; i < 1001; i++)
            {
                dp[i, 0] = 0;
                dp[i, 1] = 0;
            }
            dp[0, 0] = dp[0, 1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i, 0] = dp[i, 1] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        dp[i, 1] = Math.Max(dp[i, 1], dp[j, 0] + 1);
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i, 0] = Math.Max(dp[i, 0], dp[j, 1] + 1);
                    }
                }
            }
            return Math.Max(dp[nums.Length - 1, 0], dp[nums.Length - 1, 1]);
        }//Runtime:101 ms Beats:15% Memory:38.3 MB Beats:7.50%
        static void Main(string[] args)
        {
            Console.WriteLine(WiggleMaxLength2(new int[] { 1, 7, 4, 9, 2, 5 }));
            Console.ReadKey();
        }
    }
}
