using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MaxArea(int[] height)
        {
            int i = 0, j = height.Length - 1;
            int max = 0;
            while (i < j)
            {
                if (height[i] >= height[j])
                {
                    max = (max > (height[j] * (j - i))) ? max : (height[j] * (j - i));
                    j--;
                }
                else if (height[i] < height[j])
                {
                    max = (max > (height[i] * (j - i))) ? max : (height[i] * (j - i));
                    i++;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Console.WriteLine(MaxArea(new int[] { 1, 1 }));
            Console.ReadKey();
        }
    }
}
