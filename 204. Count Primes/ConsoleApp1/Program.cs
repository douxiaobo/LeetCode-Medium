using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int CountPrimes(int n)
        {
            if (n <= 2)
            {
                return 0;
            }
            int count = 0;
            bool[] primes = new bool[n];
            for (int i = 2; i < n; i++)
            {
                if (primes[i] == true)
                {
                    continue;
                }
                else
                {
                    int j = 2;
                    while (i * j < n)
                    {
                        primes[i * j] = true;
                        j++;
                    }
                }
                if (primes[i] != true)
                {
                    count++;
                }
            }
            return count;
        }//Runtime 158 ms Beats 52.66% Memory 34.6 MB Beats 68.60%
        public int CountPrimes1(int n)
        {
            if (n <= 2)
            {
                return 0;
            }
            int count = 0;
            bool[] primes = new bool[n];
            for (int i = 2; i < n; i++)
            {
                if (primes[i] == true)
                {
                    continue;
                }
                else
                {
                    int j = 2;
                    while (i * j < n)
                    {
                        primes[i * j] = true;
                        j++;
                    }
                }
                count++;
            }
            return count;
        }//Runtime 134 ms Beats 77.29% Memory 34.7 MB Beats 38.65%
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrimes(10));
            Console.WriteLine(CountPrimes(0));
            Console.WriteLine(CountPrimes(1));
            Console.WriteLine(CountPrimes(2));
            Console.WriteLine(CountPrimes(3));
            Console.WriteLine(CountPrimes(499979));
            Console.ReadLine(); 
        }
    }
}
