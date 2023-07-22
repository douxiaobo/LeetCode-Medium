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
    }
    public class MinStack
    {
        int index;
        int[] stack;

        public MinStack()
        {
            index = 0;
            stack = new int[30000];
        }

        public void Push(int val)
        {
            stack[index++] = val;
        }

        public void Pop()
        {
            index--;
        }

        public int Top()
        {
            return stack[index - 1];
        }

        public int GetMin()
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < index; i++)
            {
                if (min > stack[i])
                {
                    min = stack[i];
                }
            }
            return min;
        }
    }//Runtime:193 ms Beats:10.44% Memory:52.3 MB Beats:5.91%
    public class MinStack1
    {
        Stack<int> stack;

        public MinStack1()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            int min = Int32.MaxValue;
            Stack<int> tmp = new Stack<int>();
            while (stack.Count > 0)
            {
                int num = stack.Pop();
                if (num < min)
                {
                    min = num;
                }
                tmp.Push(num);
            }
            while (tmp.Count > 0)
            {
                stack.Push(tmp.Pop());
            }
            return min;
        }
    }//Runtime:789 ms Beats:5.16% Memory:63.5 MB Beats:5.91%
}
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
