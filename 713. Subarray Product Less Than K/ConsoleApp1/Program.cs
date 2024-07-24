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
            Console.WriteLine(NumSubarrayProductLessThanK(new int[] {10,5,2,6},100));
            Console.ReadKey();
        }
        public static int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int product = 1;
            int left = 0;
            int count = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                product *= nums[right];
                while (left <= right && product >= k)
                {
                    product /= nums[left++];
                }
                count += right >= left ? right - left + 1 : 0;
            }
            return count;
        }//Runtime:181 ms Beats:71.81% Memory:59.4 MB Beats:65.10%
    }
}

