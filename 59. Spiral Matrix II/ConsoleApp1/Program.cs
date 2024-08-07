﻿using System;
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
        public int[][] GenerateMatrix(int n)
        {
            int[][] res = new int[n][];
            for (int k = 0; k < n; k++)
            {
                res[k] = new int[n];
            }
            int startx = 0, starty = 0;
            int loop = n / 2;
            int mid = n / 2;
            int count = 1;
            int offset = 1;
            int i, j;
            while (loop > 0)
            {
                loop--;
                i = startx;
                j = starty;
                for (j = starty; j < n - offset; j++)
                {
                    res[startx][j] = count++;
                }
                for (i = startx; i < n - offset; i++)
                {
                    res[i][j] = count++;
                }
                for (; j > starty; j--)
                {
                    res[i][j] = count++;
                }
                for (; i > startx; i--)
                {
                    res[i][j] = count++;
                }
                startx++;
                starty++;
                offset++;
            }
            if (n % 2 == 1)
            {
                res[mid][mid] = count;
            }
            return res;
        }//Runtime:102 ms Beats:26.86% Memory:36.2 MB Beats:92.57%
    }
}
