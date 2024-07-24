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
            Solution solution = new Solution();
            Console.WriteLine(solution.SubarraySum(new int[] {2,3,5},5));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> sumToCount = new Dictionary<int, int>();
            sumToCount[0] = 1;
            int sum = 0;
            int count = 0;
            foreach (int num in nums)
            {
                sum += num;
                if (sumToCount.ContainsKey(sum - k))
                {
                    count += sumToCount[sum - k];
                }
                if (sumToCount.ContainsKey(sum))
                {
                    sumToCount[sum]++;
                }
                else
                {
                    sumToCount[sum] = 1;
                }
            }
            return count;
        }
    }//Runtime:124 ms Beats:61.11% Memory:49.9 MB Beats:28.47%
}