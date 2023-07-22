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
            Console.WriteLine(MaxProduct2(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
            Console.ReadKey();
        }
        public int MaxProduct(string[] words)
        {
            bool[][] flags = new bool[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                flags[i] = new bool[26];
                for (int j = 0; j < 26; j++)
                {
                    flags[i][j] = false;
                }
                foreach (var ch in words[i])
                {
                    flags[i][ch - 'a'] = true;
                }
            }
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    int k = 0;
                    for (; k < 26; k++)
                    {
                        if (flags[i][k] == true && flags[j][k] == true)
                        {
                            break;
                        }
                    }
                    if (k == 26)
                    {
                        int prod = words[i].Length * words[j].Length;
                        result = Math.Max(result, prod);
                    }
                }
            }
            return result;
        }//Runtime:136 ms Beats:34.48% Memory:50.9 MB Beats:37.93%
        public int MaxProduct1(string[] words)
        {
            bool[][] flags = new bool[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                flags[i] = new bool[26];
                foreach (var ch in words[i])
                {
                    flags[i][ch - 'a'] = true;
                }
            }
            int result = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    int k = 0;
                    for (; k < 26; k++)
                    {
                        if (flags[i][k] == true && flags[j][k] == true)
                        {
                            break;
                        }
                    }
                    if (k == 26)
                    {
                        int prod = words[i].Length * words[j].Length;
                        result = Math.Max(result, prod);
                    }
                }
            }
            return result;
        }//Runtime 124 ms Beats:34.48% Memory:50.5 MB Beats:41.38% 
        public static int MaxProduct2(string[] words)
        {
            int[] flags = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                foreach (char ch in words[i])
                {
                    flags[i] |= 1 << (ch - 'a');
                }
            }
            int result = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if ((flags[i] & flags[j]) == 0)
                    {
                        int prod = words[i].Length * words[j].Length;
                        result = Math.Max(result, prod);
                    }
                }
            }
            return result;
        }//Runtime:100 ms Beats:82.76% Memory:48.8 MB Beats:100%
    }
}
