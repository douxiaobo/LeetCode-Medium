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
        public int FindMinDifference(IList<string> timePoints)
        {
            if (timePoints.Count > 1440)
            {
                return 0;
            }
            bool[] minuteFlags = new bool[1440];
            foreach (string time in timePoints)
            {
                string[] t = time.Split(":");
                int min = int.Parse(t[0]) * 60 + int.Parse(t[1]);
                if (minuteFlags[min])
                {   //默认true
                    return 0;
                }
                minuteFlags[min] = true;
            }
            return helper(minuteFlags);
        }
        private int helper(bool[] minuteFlags)
        {
            int minDiff = minuteFlags.Length - 1;
            int prev = -1;
            int first = minuteFlags.Length - 1;
            int last = -1;
            for (int i = 0; i < minuteFlags.Length; i++)
            {
                if (minuteFlags[i])
                {
                    if (prev >= 0)
                    {
                        minDiff = Math.Min(i - prev, minDiff);
                    }
                    prev = i;
                    first = Math.Min(i, first);
                    last = Math.Max(i, last);
                }
            }
            minDiff = Math.Min(first + minuteFlags.Length - last, minDiff);
            return minDiff;
        }
    }
}
