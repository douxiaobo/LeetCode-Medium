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
            int divident = 10;
            int divisor = 3;
            Solution1 solution = new Solution1();
            Console.WriteLine(solution.Divide(divident,divisor));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 080000000 && divisor == -1)
            {
                return Int32.MaxValue;
            }
            int negative = 2;
            if (dividend > 0)
            {
                negative--;
                dividend = -dividend;
            }
            if (divisor > 0)
            {
                negative--;
                divisor = -divisor;
            }
            int result = divideCore(dividend, divisor);
            return negative == 1 ? -result : result;
        }
        private int divideCore(int dividend, int divisor)
        {
            int result = 0;
            while (dividend <= divisor)
            {
                int value = divisor;
                int quotient = 1;
                while (value >= 0xc0000000 && dividend <= value + value)
                {
                    quotient += quotient;
                    value += value;
                }
                result += quotient;
                dividend -= value;
            }
            return result;
        }
    }
    public class Solution1
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor == -1)
            {
                return Int32.MaxValue;
            }

            int sign = (dividend > 0) ^ (divisor > 0) ? -1 : 1; //异或
            long ldividend = Math.Abs((long)dividend);
            long ldivisor = Math.Abs((long)divisor);

            int result = 0;
            while (ldividend >= ldivisor)
            {
                long temp = ldivisor;
                long multiple = 1;
                while (ldividend >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                ldividend -= temp;
                result += (int)multiple;
            }

            return sign * result;
        }
    }
}
