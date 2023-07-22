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
    public class Solution1      //带缓存的递归代码
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            dp = Enumerable.Repeat(-1, dp.Length).ToArray();//使用LINQ的方法
            helper(nums, nums.Length - 1, dp);
            return dp[nums.Length - 1];
        }
        private void helper(int[] nums, int i, int[] dp)
        {
            if (i == 0)
            {
                dp[i] = nums[0];
            }
            else if (i == 1)
            {
                dp[i] = Math.Max(nums[0], nums[1]);
            }
            else if (dp[i] < 0)
            {
                helper(nums, i - 2, dp);
                helper(nums, i - 1, dp);
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
        }
    }//Runtime:89 ms Beats:44.32% Memory:38 MB Beats:77.59%
    public class Solution2      //空间复杂度为O(n)的迭代代码
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            if (nums.Length > 1)
            {
                dp[1] = Math.Max(nums[0], nums[1]);
            }
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
            return dp[nums.Length - 1];
        }
    }//Runtime：73 ms Beats：97.77% Memory：37.8 MB Beats：94.62%
    public class Solution3      //空间复杂度为O(1)的迭代代码
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[2];
            dp[0] = nums[0];
            if (nums.Length > 1)
            {
                dp[1] = Math.Max(nums[0], nums[1]);
            }
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i % 2] = Math.Max(dp[(i - 1) % 2], dp[(i - 2) % 2] + nums[i]);
            }
            return dp[(nums.Length - 1) % 2];
        }
    }//Runtime：81 ms Beats：84.89% Memory：38.3 MB Beats：25.86%
    public class Solution4      //用两个状态转移方程分析解决问题
    {
        public int Rob(int[] nums)
        {
            int len = nums.Length;
            if (len == 0)
            {
                return 0;
            }
            int[][] dp = new int[2][] { new int[2], new int[2] };
            dp[0][0] = 0;
            dp[1][0] = nums[0];
            for (int i = 1; i < len; i++)
            {
                dp[0][i % 2] = Math.Max(dp[0][(i - 1) % 2], dp[1][(i - 1) % 2]);
                dp[1][i % 2] = nums[i] + dp[0][(i - 1) % 2];
            }
            return Math.Max(dp[0][(len - 1) % 2], dp[1][(len - 1) % 2]);
        }
    }//Runtime：87 ms Beats：55.58% Memory：38.4 MB Beats：25.86%
}
