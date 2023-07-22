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
            Console.WriteLine(SingleNumber(new int[] { 2, 2, 3, 2 }));
            Console.ReadKey();
        }
        public static int SingleNumber(int[] nums)      //调试作用，暂时没看懂。
        {
            int[] bitSums = new int[4];
            foreach (int num in nums)
            {
                for (int i = 0; i < 4; i++)
                {
                    bitSums[i] += (num >> (3 - i)) & 1;
                }
            }
            int result = 0;
            for (int i = 0; i < 4; i++)
            {
                result = (result << 1) + bitSums[i] % 3;
            }
            return result;
        }
        public int SingleNumber1(int[] nums)        //没看懂
        {
            int[] bitSums = new int[32];
            foreach (int num in nums)
            {
                for (int i = 0; i < 32; i++)
                {
                    bitSums[i] += (num >> (31 - i)) & 1;
                }
            }
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                result = (result << 1) + bitSums[i] % 3;
            }
            return result;
        }//Runtime：94 ms Beats：50% Memory：39.6 MB Beats：65.38%
        public int SingleNumber2(int[] nums)        //没看懂
        {
            int res = 0;
            for (int i = 0; i < 32; i++)    // 遍历32位二进制
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)   // 遍历数组
                {
                    count += (nums[j] >> i) & 1;    // 统计在该位上1的个数
                }
                res |= (count % 3) << i;     // 将该位还原成十进制数
            }
            return res;
        }//Runtime 76 ms Beats：98.72% Memory：39.3 MB Beats：80.77%
    }
}
