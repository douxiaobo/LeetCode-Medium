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
        public int PeakIndexInMountainArray(int[] arr)
        {
            int left = 1;
            int right = arr.Length - 2;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                {
                    return mid;
                }
                if (arr[mid] > arr[mid - 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }//Runtime:216 ms Beats:41.9% Memory:51.8 MB Beats:50%
    }
}
