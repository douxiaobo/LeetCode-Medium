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
            Console.WriteLine(CheckInclusion1("ab", "eidboaoo"));
            Console.ReadKey();
        }
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                return false;
            }
            int[] counts = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                counts[s1[i] - 'a']++;
                counts[s2[i] - 'a']--;
            }
            if (areAllZero(counts))
            {
                return true;
            }
            for (int i = s1.Length; i < s2.Length; i++)
            {
                counts[s2[i] - 'a']--;
                counts[s2[i - s1.Length] - 'a']++;
                if (areAllZero(counts))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool areAllZero(int[] counts)
        {
            foreach (int count in counts)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;
        }//Runtime:78 ms Beats:77.59% Memory:39.5 MB Beats:89.7%
        public static bool CheckInclusion1(string s1, string s2)
        {
            {
                if (s1.Length > s2.Length) return false;

                var s1Count = Enumerable.Repeat(0, 26).ToArray();
                var s2Count = Enumerable.Repeat(0, 26).ToArray();

                for (var i = 0; i < s1.Length; i++)
                {
                    s1Count[s1[i] - 'a']++;
                    s2Count[s2[i] - 'a']++;
                }

                var matches = 0;
                for (var i = 0; i < 26; i++)
                {
                    if (s1Count[i] == s2Count[i]) matches++;
                }

                var left = 0;
                for (var right = s1.Length; right < s2.Length; right++)
                {
                    if (matches == 26) return true;

                    var index = s2[right] - 'a';
                    s2Count[index]++;
                    if (s1Count[index] == s2Count[index])
                    {
                        matches++;
                    }
                    else if (s1Count[index] + 1 == s2Count[index])
                    {
                        matches--;
                    }

                    index = s2[left] - 'a';
                    s2Count[index]--;
                    if (s1Count[index] == s2Count[index])
                    {
                        matches++;
                    }
                    else if (s1Count[index] - 1 == s2Count[index])
                    {
                        matches--;
                    }

                    left++;
                }

                return matches == 26;
            }
        }
    }
}
