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
            Console.WriteLine(SingleNonDuplicate(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }));
            Console.WriteLine(SingleNonDuplicate(new int[] { 3, 3, 7, 7, 10, 11, 11 }));
            Console.WriteLine(SingleNonDuplicate(new int[] { 3, 3, 11, 11, 23, 23, 31 }));
            Console.ReadKey();
        }
        public static int SingleNonDuplicate(int[] nums)
        {
            int left = 0;
            int right = nums.Length / 2;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int i = mid * 2;
                if (i < nums.Length - 1 && nums[i] != nums[i + 1])
                {
                    if (mid == 0 || nums[i - 2] == nums[i - 1])
                    {
                        return nums[i];
                    }
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return nums[nums.Length - 1];
        }//Runtime:117 ms Beats:33.33% Memory:46 MB Beats:67.68%
    }
}
