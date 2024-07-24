using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = -10000;
            int cur = -10000;
            foreach (int num in nums)
            {
                cur = Math.Max(num, cur + num);
                max = (cur > max) ? cur : max;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(MaxSubArray(new int[] { 1 }));
            Console.WriteLine(MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));
            Console.WriteLine(MaxSubArray(new int[] { -2, -1,  }));
            Console.ReadKey();
        }
        public int MaxSubArray1(int[] nums)
        {
            int result = int.MinValue;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    count += nums[j];
                    result = count > result ? count : result;
                }
            }
            return result;
        }//Time Limit Exceeded
        public int MaxSubArray2(int[] nums)
        {
            int result = int.MinValue;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i];
                if (count > result)
                {
                    result = count;
                }
                if (count <= 0)
                {
                    count = 0;
                }
            }
            return result;
        }//Runtime:225 ms Beats:7.58% Memory:49.9 MB Beats:91.92%
        public int MaxSubArray3(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 0;
            }
            dp[0] = nums[0];
            int result = dp[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
                if (dp[i] > result)
                {
                    result = dp[i];
                }
            }
            return result;
        }//Runtime:226 ms Beats:7.21% Memory:50.9 MB Beats:6.77%
    }
}
