using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            while ((i < j) && (numbers[i] + numbers[j] != target))
            {
                if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return new int[] { i + 1, j + 1 };
        }//Runtime:153 ms Beats:69.76% Memory:46.2 MB Beats:64.77%
        static void Main(string[] args)
        {
        }
    }
}
