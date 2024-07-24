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
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = 0;
            int closest = Int32.MaxValue;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (closest > Math.Abs(sum - target))
                        {
                            closest = Math.Abs(sum - target);
                            result = sum;
                        }
                    }
                }
            }
            return result;
        }
    }//Runtime:603 ms Beats:18.65% Memory:39.6 MB Beats:63.32%
}
