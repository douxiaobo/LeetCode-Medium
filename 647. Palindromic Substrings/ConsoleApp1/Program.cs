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
        public int CountSubstrings(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count += countPalindrome(s, i, i);
                count += countPalindrome(s, i, i + 1);
            }
            return count;
        }
        private int countPalindrome(String s, int start, int end)
        {
            int count = 0;
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                count++;
                start--;
                end++;
            }
            return count;
        }//Runtime:77 ms Beats:36.60% Memory:36.7 MB Beats:31.37%
    }
}
