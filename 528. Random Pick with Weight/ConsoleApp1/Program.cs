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
    }
    public class Solution
    {
        private int[] sums;
        private int total;

        public Solution(int[] w)
        {
            sums = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                total += w[i];
                sums[i] = total;
            }
        }

        public int PickIndex()
        {
            Random random = new Random();
            int p = random.Next(total);
            int left = 0;
            int right = sums.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (sums[mid] > p)
                {
                    if (mid == 0 || (sums[mid - 1] <= p))
                    {
                        return mid;
                    }
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }//Runtime:225 ms Beats:32.46% Memory:60.1 MB Beats:39.47%
}
