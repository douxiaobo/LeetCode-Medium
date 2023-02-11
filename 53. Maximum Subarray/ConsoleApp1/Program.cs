using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = -10000;
            int cur = -10000;
            foreach (int num in nums)
            {
                cur = Math.Max(num, cur + num);
                max = (cur > max) ? cur : max;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(MaxSubArray(new int[] { 1 }));
            Console.WriteLine(MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));
            Console.WriteLine(MaxSubArray(new int[] { -2, -1,  }));
            Console.ReadKey();
        }
    }
}
