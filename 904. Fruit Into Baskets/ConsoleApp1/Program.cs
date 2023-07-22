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
            Console.WriteLine(TotalFruit1(new int[] { 0, 1, 2, 2 }));
            Console.WriteLine(TotalFruit1(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }));
            Console.ReadKey();
        }
        public int TotalFruit(int[] fruits)
        {
            Dictionary<int, int> basket = new Dictionary<int, int>();
            int left = 0, right = 0, count = 0, res = 0;
            while (right < fruits.Length)
            {
                if (!basket.ContainsKey(fruits[right]))
                {
                    basket[fruits[right]] = 1;
                }
                else
                {
                    basket[fruits[right]]++;
                }
                count++;
                while (basket.Count > 2)
                {
                    basket[fruits[left]]--;
                    if (basket[fruits[left]] == 0)
                    {
                        basket.Remove(fruits[left]);
                    }
                    left++;
                    count--;
                }
                res = Math.Max(res, count);
                right++;
            }
            return res;
        }//Runtime:221 ms Beats:73.24% Memory:52.2 MB Beats:66.20%
        public static int TotalFruit1(int[] fruits)
        {
            List<int> ls = new List<int>();
            int left = 0;
            int result = 0;
            int subLength = 0;
            for (int right = 0; right < fruits.Length; right++)
            {
                if (!ls.Contains(fruits[right]))
                {
                    ls.Add(fruits[right]);
                }
                if (ls.Count() > 2)
                {
                    ls.Remove(fruits[left]);
                    while (!ls.Contains(fruits[left]))
                    {
                        left++;
                    }
                    int temp = left;
                    while (temp <= right)
                    {
                        if (!ls.Contains(fruits[temp]))
                        {
                            ls.Add(fruits[temp]);
                        }
                        temp++;
                    }
                }
                if (ls.Count() <= 2 && left <= right)
                {
                    subLength = (right - left + 1);
                    result = Math.Max(result, subLength);
                }
            }
            return result;
        }//Runtime:248 ms Beats:17.27% Memory:52.2 MB Beats:65.47%
    }
}
