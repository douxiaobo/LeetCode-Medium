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
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int result1 = helper(nums, 0, nums.Length - 2);
            int result2 = helper(nums, 1, nums.Length - 1);
            return Math.Max(result1, result2);
        }
        private int helper(int[] nums, int start, int end)
        {
            int[] dp = new int[2];
            dp[0] = nums[start];
            if (start < end)
            {
                dp[1] = Math.Max(nums[start], nums[start + 1]);
            }
            for (int i = start + 2; i <= end; i++)
            {
                int j = i - start;
                dp[j % 2] = Math.Max(dp[(j - 1) % 2], dp[(j - 2) % 2] + nums[i]);
            }
            return dp[(end - start) % 2];
        }
    }//Runtime:94 ms Beats:22.58% Memory:38.1 MB Beats:70.97% 
}
