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
        public IList<int> FindAnagrams(string s, string p)
        {
            List<int> indices = new List<int>();
            if (s.Length < p.Length)
            {
                return indices;
            }
            int[] counts = new int[26];
            int i = 0;
            for (; i < p.Length; i++)
            {
                counts[p[i] - 'a']++;
                counts[s[i] - 'a']--;
            }
            if (areAllZero(counts))
            {
                indices.Add(0);
            }
            for (; i < s.Length; i++)
            {
                counts[s[i] - 'a']--;
                counts[s[i - p.Length] - 'a']++;
                if (areAllZero(counts))
                {
                    indices.Add(i - p.Length + 1);
                }
            }
            return indices;
        }
        private bool areAllZero(int[] counts)
        {
            foreach (int count in counts)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;
        }//Runtime:139 ms Beats:74.26% Memory:47.2 MB Beats:41%
    }
}
