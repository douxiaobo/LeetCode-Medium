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
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -asteroid)
                {
                    stack.Pop();
                }
                if (stack.Count > 0 && asteroid < 0 && stack.Peek() == -asteroid)
                {
                    stack.Pop();
                }
                else if (asteroid > 0 || stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                }
            }
            int[] res = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                res[i] = stack.Pop();
            }
            return res;
        }//Runtime:161 ms Beats:22.69% Memory:46.2 MB Beats:19.33%
        public int[] AsteroidCollision1(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int ast in asteroids)
            {
                while (stack.Count > 0 && (stack.Peek() > 0 && stack.Peek() < -ast))    //这个比较重要，没搞清楚为什么用while。
                {
                    stack.Pop();
                }
                if (ast > 0 || stack.Count == 0 || (stack.Peek() < 0))
                {
                    stack.Push(ast);
                }
                else if (stack.Count > 0 && (stack.Peek() == -ast))
                {
                    stack.Pop();
                }
            }
            int[] res = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                res[i] = stack.Pop();
            }
            return res;
        }//Runtime:157 ms Beats:36.13% Memory:45.9 MB Beats:52.10%
    }
}
