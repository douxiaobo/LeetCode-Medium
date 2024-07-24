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
            IList<IList<string>> list = new List<IList<string>>(solution.Partition("aab"));
            PrintListOfLists(list);
            Console.ReadKey();
        }
        static void PrintListOfLists(IList<IList<string>> listOfLists)
        {
            foreach (IList<string> list in listOfLists)
            {
                foreach (string item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Solution
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<string>> result = new List<IList<string>>();
            helper(s, 0, new List<string>(), result);
            return result;
        }
        private void helper(string str, int start, List<string> substrings, List<IList<string>> result)
        {
            if (start == str.Length)
            {
                result.Add(new List<string>(substrings));
                return;
            }
            for (int i = start; i < str.Length; i++)
            {
                if (isPalindrome(str, start, i))
                {
                    substrings.Add(str.Substring(start, i - start + 1));
                    helper(str, i + 1, substrings, result);
                    substrings.RemoveAt(substrings.Count - 1);
                }
            }
        }
        private bool isPalindrome(string str, int start, int end)
        {
            while (start < end)
            {
                if (str[start++] != str[end--])
                {
                    return false;
                }
            }
            return true;
        }
    }//Runtime:513 ms Beats:96.27% Memory:140.7 MB Beats:54.85%
}
