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
            int[][] arr = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } };
            Console.WriteLine(FindCircleNum1(arr));
            Console.ReadLine();
        }
        public static int FindCircleNum(int[][] isConnected)
        {
            bool[] visited = new bool[isConnected.Length];
            int result = 0;
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (!visited[i])
                {
                    findCircle(isConnected, visited, i);
                    result++;
                }
            }
            return result;
        }
        private static void findCircle(int[][] M, bool[] visited, int i)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(i);
            visited[i] = true;
            while (queue.Count > 0)
            {
                int t = queue.Dequeue();
                for (int friend = 0; friend < M.Length; friend++)
                {
                    if (M[t][friend] == 1 && !visited[friend])
                    {
                        queue.Enqueue(friend);
                        visited[friend] = true;
                    }
                }
            }
        }//Runtime:105 ms Beats:83% Memory:45.1 MB Beats:51.87%
        public static int FindCircleNum1(int[][] isConnected)
        {
            int[] fathers = new int[isConnected.Length];
            for (int i = 0; i < fathers.Length; i++)
            {
                fathers[i] = i;
            }
            int count = isConnected.Length;
            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = i + 1; j < isConnected.Length; j++)
                {
                    if (isConnected[i][j] == 1 && union(fathers, i, j))
                    {
                        count--;
                    }
                }
            }
            return count;
        }
        private static int findFather(int[] fathers, int i)
        {
            if (fathers[i] != i)
            {
                fathers[i] = findFather(fathers, fathers[i]);
            }
            return fathers[i];
        }
        private static bool union(int[] fathers, int i, int j)
        {
            int fatherOfI = findFather(fathers, i);
            int fatherOfJ = findFather(fathers, j);
            if (fatherOfI != fatherOfJ)
            {
                fathers[fatherOfI] = fatherOfJ;
                return true;
            }
            return false;
        }//Runtime:110 ms Beats:63.41% Memory:44.2 MB Beats:99.70%
    }
}
