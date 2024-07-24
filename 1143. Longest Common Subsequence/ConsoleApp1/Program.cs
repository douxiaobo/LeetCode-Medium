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
            Console.WriteLine(LongestCommonSubsequence("abcde","ace"));
            Console.ReadKey();
        }
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int len1 = text1.Length;
            int len2 = text2.Length;
            int[][] dp = new int[len1 + 1][];
            for (int i = 0; i < len1 + 1; i++)
            {
                dp[i] = new int[len2 + 1];
            }
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        dp[i + 1][j + 1] = dp[i][j] + 1;
                    }
                    else
                    {
                        dp[i + 1][j + 1] = Math.Max(dp[i][j + 1], dp[i + 1][j]);
                    }
                }
            }
            return dp[len1][len2];
        }//Runtime:84 ms Beats:51.1% Memory:48.4 MB Beats:21.45%
        public int LongestCommonSubsequence1(string text1, string text2)
        {
            int len1 = text1.Length;
            int len2 = text2.Length;
            if (len1 < len2)
            {
                return LongestCommonSubsequence1(text2, text1);
            }
            int[][] dp = new int[2][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[len2 + 1];
            }
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        dp[(i + 1) % 2][j + 1] = dp[i % 2][j] + 1;
                    }
                    else
                    {
                        dp[(i + 1) % 2][j + 1] = Math.Max(dp[i % 2][j + 1], dp[(i + 1) % 2][j]);
                    }
                }
            }
            return dp[len1 % 2][len2];
        }//Runtime:85 ms Beats:49.28% Memory:36 MB Beats:99.42% 
        public int LongestCommonSubsequence2(string text1, string text2)
        {
            int len1 = text1.Length;
            int len2 = text2.Length;
            if (len1 < len2)
            {
                return LongestCommonSubsequence2(text2, text1);
            }
            int[] dp = new int[len2 + 1];
            for (int i = 0; i < len1; i++)
            {
                int prev = dp[0];
                for (int j = 0; j < len2; j++)
                {
                    int cur;
                    if (text1[i] == text2[j])
                    {
                        cur = prev + 1;
                    }
                    else
                    {
                        cur = Math.Max(dp[j], dp[j + 1]);
                    }
                    prev = dp[j + 1];
                    dp[j + 1] = cur;
                }
            }
            return dp[len2];
        }//Runtime:64 ms Beats:98.26% Memory:36.1 MB Beats:98.84%
    }
}
