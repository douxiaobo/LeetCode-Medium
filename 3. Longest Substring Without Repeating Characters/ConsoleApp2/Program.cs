using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.ReadKey();
        }
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int[] counts = new int[256];
            int i = 0;
            int j = -1;
            int longest = 1;
            for (; i < s.Length; i++)
            {
                counts[s[i]]++;
                while (hasGreaterThan1(counts))
                {
                    ++j;
                    counts[s[j]]--;
                }
                longest = Math.Max(i - j, longest);
            }
            return longest;
        }
        private static bool hasGreaterThan1(int[] counts)
        {
            foreach (int count in counts)
            {
                if (count > 1)
                {
                    return true;
                }
            }
            return false;
        }//Runtime:80 ms Beats:52.14% Memory:40.1 MB Beats:49.13%
        public int LengthOfLongestSubstring1(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int[] counts = new int[256];
            int i = 0;
            int j = -1;
            int longest = 1;
            int countDup = 0;
            for (; i < s.Length; i++)
            {
                counts[s[i]]++;
                if (counts[s[i]] == 2)
                {
                    countDup++;
                }
                while (countDup > 0)
                {
                    j++;
                    counts[s[j]]--;
                    if (counts[s[j]] == 1)
                    {
                        countDup--;
                    }
                }
                longest = Math.Max(i - j, longest);
            }
            return longest;
        }//Runtime:72 ms Beats:75.45% Memory:40.3 MB Beats:43.14%
    }
}
