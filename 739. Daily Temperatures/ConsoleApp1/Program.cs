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
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                for (int j = i; j < temperatures.Length; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        res[i] = j - i;
                        break;
                    }
                }
            }
            return res;
        }//Runtime:2850 ms Beats:11.38% Memory:62.2 MB Beats:66.74%
        public int[] DailyTemperatures1(int[] temperatures)
        {
            Stack<int> st = new Stack<int>();
            int[] res = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                res[i] = 0;
            }
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (st.Count() > 0 && temperatures[i] > temperatures[st.Peek()])
                {
                    res[st.Peek()] = i - st.Peek();
                    st.Pop();
                }
                st.Push(i);
            }
            return res;
        }//Runtime:362 ms Beats:31.47% Memory:63.5 MB Beats:44.87%
    }
}
