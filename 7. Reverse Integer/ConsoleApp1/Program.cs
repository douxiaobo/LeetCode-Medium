using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int Reverse(int x)
        {
            int num = 0;
            while (x != 0)
            {
                if (num > Int32.MaxValue / 10 || num < Int32.MinValue / 10)
                {
                    return 0;
                }
                num = num * 10 + x % 10;
                x = x / 10;
            }
            return num;
        }
        static void Main(string[] args)
        {
        }
    }
}
