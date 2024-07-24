using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int result = Int32.MaxValue;
            int sum = 0;
            int i = 0;
            int subLength = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += nums[j];
                while (sum >= target)
                {
                    subLength = (j - i + 1);
                    result = result < subLength ? result : subLength;
                    sum -= nums[i++];
                }
            }
            return result == Int32.MaxValue ? 0 : result;
        }//Runtime:119 ms Beats:82.14% Memory:46.9 MB Beats:64.58%
        static void Main(string[] args)
        {
        }
        public int MinSubArrayLen1(int target, int[] nums)
        {
            int left = 0;
            int sum = 0;
            int minLength = Int32.MaxValue;
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (left <= right && sum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    sum -= nums[left++];
                }
            }
            return minLength == Int32.MaxValue ? 0 : minLength;
        }//Runtime:140 ms Beats:5.59% Memory:47.3 MB Beats:5.5%
    }
}
