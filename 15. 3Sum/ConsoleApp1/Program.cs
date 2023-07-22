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
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length >= 3)
            {
                Array.Sort(nums);
                int i = 0;
                while (i < nums.Length - 2)
                {
                    twoSum(nums, i, result);
                    int temp = nums[i];
                    while (i < nums.Length && nums[i] == temp)
                    {
                        i++;
                    }
                }
            }
            return result;
        }
        public void twoSum(int[] nums, int i, List<IList<int>> result)
        {
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                if (nums[i] + nums[j] + nums[k] == 0)
                {
                    List<int> lstemp = new List<int>();
                    lstemp.Add(nums[i]);
                    lstemp.Add(nums[j]);
                    lstemp.Add(nums[k]);
                    result.Add(lstemp);
                    int temp = nums[j];
                    while (nums[j] == temp && j < k)
                    {
                        j++;
                    }
                }
                else if (nums[i] + nums[j] + nums[k] < 0)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
        }//Runtime:213 ms Beats:54.63% Memory:61.4 MB Beats:29.38%
        public IList<IList<int>> ThreeSum1(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                HashSet<int> set = new HashSet<int>();
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 2 && nums[j] == nums[j - 1] && nums[j - 1] == nums[j - 2])
                    {
                        continue;
                    }
                    int c = 0 - (nums[i] + nums[j]);
                    if (set.Contains(c))
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        temp.Add(c);
                        result.Add(new List<int>(temp));
                        set.Remove(c);
                    }
                    else
                    {
                        set.Add(nums[j]);
                    }
                }
            }
            return result;
        }//Runtime:494 ms Beats:23.54% Memory:63.7 MB Beats:14.14%
        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {//如果i<nums.Length-2;结果是Runtime：206 ms Beats：70.62 % Memory：61.4 MB Beats：29.38 %
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else if (nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[left]);
                        temp.Add(nums[right]);
                        result.Add(temp);
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        right--;
                        left++;
                    }
                }
            }
            return result;
        }//Runtime:200 ms Beats:83.67% Memory:61.2 MB Beats:35.42%
    }
}
