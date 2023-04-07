using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int GetSum(int a, int b)      //代码不可行， 缺少负数的考虑。     
        {
            Queue<int> Qa = new Queue<int>();
            Queue<int> Qb = new Queue<int>();
            while (a != 0)
            {
                Qa.Enqueue(a % 2);
                a = a / 2;
            }
            while (b != 0)
            {
                Qb.Enqueue(b % 2);
                b = b / 2;
            }
            int num = 0, count = 0, plus = 0;
            while (Qa.Count > 0 || Qb.Count > 0)
            {
                int aa, bb;
                if (Qa.Count > 0)
                {
                    aa = Qa.Dequeue();
                }
                else
                {
                    aa = 0;
                }
                if (Qb.Count > 0)
                {
                    bb = Qb.Dequeue();
                }
                else
                {
                    bb = 0;
                }
                if (aa == 1 && bb == 1 && plus == 1)
                {
                    plus = 1;
                    num += 1 * (int)Math.Pow(2, count++);
                }
                else if ((aa == 1 && bb == 0 && plus == 1) || (aa == 0 && bb == 1 && plus == 1) || (aa == 1 && bb == 1 && plus == 0))
                {
                    plus = 1;
                    num += 0 * (int)Math.Pow(2, count++);
                }
                else if (aa == 0 && bb == 0 && plus == 0)
                {
                    plus = 0;
                    num += 0 * (int)Math.Pow(2, count++);
                }
                else
                {
                    plus = 0;
                    num += 1 * (int)Math.Pow(2, count++);
                }
            }
            if (plus == 1)
            {
                num += 1 * (int)Math.Pow(2, count);
            }
            return num;
        }
        public static int GetSum1(int a, int b)     //Bit Manipulation
        {
            while (b != 0)      //while(b>0)是不可行，缺少负数的考虑。
            {
                int c = a & b;
                a = a ^ b;
                b = (c << 1);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum1(2,3));
            Console.ReadKey();
        }
    }
}
