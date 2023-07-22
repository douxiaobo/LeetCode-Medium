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
            Console.WriteLine(MinEatingSpeed(new int[] {3,6,7,11},8));
            Console.ReadKey();
        }
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int max = Int32.MinValue;
            foreach (int pile in piles)
            {
                max = Math.Max(max, pile);
            }
            int left = 1;
            int right = max;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int hours = getHours(piles, mid);
                if (hours <= h)
                {
                    if (mid == 1 || getHours(piles, mid - 1) > h)
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
        private static int getHours(int[] piles, int speed)
        {
            int hours = 0;
            foreach (int pile in piles)
            {
                hours += (pile + speed - 1) / speed;
            }
            return hours;
        }
    }
    
}
