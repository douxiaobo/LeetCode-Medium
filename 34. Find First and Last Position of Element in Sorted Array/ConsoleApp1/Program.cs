using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] num = new int[2] { -1, -1 };
            if (nums.Length == 1 && nums[0] == target)
            {
                num[0] = num[1] = 0;
            }
            else
            {
                int left = 0, right = nums.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        int cur = mid;
                        while (cur > 0 && nums[cur - 1] == target)
                        {
                            cur--;
                        }
                        num[0] = cur;
                        while (cur < nums.Length && nums[cur] == target)
                        {
                            cur++;
                        }
                        num[1] = cur - 1;
                        if (cur == num[0])
                        {
                            num[1] = cur;
                        }
                        break;
                    }
                }
            }
            return num;
        }//Runtime 149 ms Beats 66.46% Memory 44.7 MB Beats 60.87%
        public int[] SearchRange1(int[] nums, int target)
        {
            int[] num = new int[2] { -1, -1 };
            if (nums.Length == 1 && nums[0] == target)
            {
                num[0] = num[1] = 0;
            }
            else
            {
                int left = 0, right = nums.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        int cur = mid;
                        while (cur > 0 && nums[cur - 1] == target)
                        {
                            cur--;
                        }
                        num[0] = cur;
                        while (cur < nums.Length && nums[cur] == target)
                        {
                            cur++;
                        }
                        num[1] = cur - 1;
                        break;
                    }
                }
            }
            return num;
        }//Runtime 154 ms Beats 45.44% Memory 44.9 MB Beats 34.47%
        static void Main(string[] args)
        {
        }
    }
}
