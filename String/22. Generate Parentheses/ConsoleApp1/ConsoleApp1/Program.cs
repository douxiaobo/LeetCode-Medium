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
            Console.WriteLine(solution.GenerateParenthesis(3));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            helper(n, n, "", result);
            return result;
        }
        private void helper(int left, int right, string parenthesis, List<string> result)
        {
            if (left == 0 && right == 0)
            {
                result.Add(parenthesis);
                return;
            }
            if (left > 0)
            {
                helper(left - 1, right, parenthesis + "(", result);
            }
            if (left < right)
            {
                helper(left, right - 1, parenthesis + ")", result);
            }
        }
    }
    public class Solution1
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            GenerateParenthesesHelper("", 0, 0, n, result);
            return result;
        }
        private void GenerateParenthesesHelper(string current, int open, int close, int max, List<string> result)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max)
            {
                GenerateParenthesesHelper(current + "(", open + 1, close, max, result);
            }

            if (close < open)
            {
                GenerateParenthesesHelper(current + ")", open, close + 1, max, result);
            }
        }
    }
}