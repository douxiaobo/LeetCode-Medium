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
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    int num1 = stack.Pop();
                    int num2 = stack.Pop();
                    if (tokens[i] == "+")
                    {
                        stack.Push(num1 + num2);
                    }
                    else if (tokens[i] == "-")
                    {
                        stack.Push(num2 - num1);
                    }
                    else if (tokens[i] == "*")
                    {
                        stack.Push(num1 * num2);
                    }
                    else if (tokens[i] == "/")
                    {
                        stack.Push(num2 / num1);
                    }
                }
                else
                {
                    stack.Push(int.Parse(tokens[i]));
                }
            }
            return stack.Pop();
        }//Runtime:93 ms Beats:53.48% Memory:40.3 MB Beats:55.95%
        public int EvalRPN1(string[] tokens)
        {
            int[] stack = new int[tokens.Length];
            int stacktop = -1;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    int num1 = stack[stacktop--];
                    int num2 = stack[stacktop--];
                    if (tokens[i] == "+")
                    {
                        stack[++stacktop] = (num1 + num2);
                    }
                    else if (tokens[i] == "-")
                    {
                        stack[++stacktop] = (num2 - num1);
                    }
                    else if (tokens[i] == "*")
                    {
                        stack[++stacktop] = (num1 * num2);
                    }
                    else if (tokens[i] == "/")
                    {
                        stack[++stacktop] = (num2 / num1);
                    }
                }
                else
                {
                    stack[++stacktop] = int.Parse(tokens[i]);
                }
            }
            return stack[stacktop];
        }//Runtime:81 ms Beats:94.83% Memory:40.2 MB Beats:55.95%
    }
}
