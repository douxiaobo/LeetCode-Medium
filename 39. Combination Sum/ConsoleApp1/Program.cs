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
            Console.WriteLine(solution.CombinationSum(new int[] {2,3,6,7 },7));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> combination = new List<int>();
            helper(candidates, target, 0, combination, result);
            return result;
        }
        private void helper(int[] nums, int target, int i, List<int> combination, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
            }
            else if (target > 0 && i < nums.Length)
            {
                helper(nums, target, i + 1, combination, result);
                combination.Add(nums[i]);
                helper(nums, target - nums[i], i, combination, result);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
