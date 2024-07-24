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
            int[] nums = new int[] { 0,1,0};
            Console.WriteLine(solution.FindMaxLength(nums));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> sumToIndex = new Dictionary<int, int>();
            sumToIndex[0] = -1;
            int sum = 0;
            int maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? -1 : 1;
                if (sumToIndex.ContainsKey(sum))
                {
                    int value;
                    if(sumToIndex.TryGetValue(sum,out value))
                    {
                        maxLength = Math.Max(maxLength, i - value);
                    }
                }
                else
                {
                    sumToIndex[sum] = i;
                }
            }
            return maxLength;
        }
    }
}
