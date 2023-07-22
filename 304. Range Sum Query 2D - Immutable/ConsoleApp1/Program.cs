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
        public class NumMatrix
        {
            private int[,] sums;

            public NumMatrix(int[][] matrix)
            {
                if (matrix.Length == 0 || matrix[0].Length == 0)
                {
                    return;
                }
                sums = new int[matrix.Length + 1, matrix[0].Length + 1];
                for (int i = 0; i < matrix.Length; i++)
                {
                    int rowSum = 0;
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        rowSum += matrix[i][j];
                        sums[i + 1, j + 1] = sums[i, j + 1] + rowSum;
                    }
                }

            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                return sums[row2 + 1, col2 + 1] - sums[row1, col2 + 1] - sums[row2 + 1, col1] + sums[row1, col1];
            }
        }//Runtime:1059 ms Beats:91.86% Memory:97.8 MB Beats:68.60%

    }
}
