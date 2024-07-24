using System;
using System.Collections;
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
    public class RandomizedSet
    {
        Dictionary<int, int> numToLocation;
        ArrayList nums;

        public RandomizedSet()
        {
            numToLocation = new Dictionary<int, int>();
            nums = new ArrayList();
        }

        public bool Insert(int val)
        {
            if (numToLocation.ContainsKey(val))
            {
                return false;
            }
            numToLocation.Add(val, nums.Count);
            nums.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!numToLocation.ContainsKey(val))
            {
                return false;
            }
            int location = numToLocation[val];
            //numToLocation.Add((int)nums[nums.Count-1],location);
            //numToLocation.Remove(val);
            //nums[location]=nums[nums.Count-1];
            //nums.Remove(nums.Count-1);        
            int lastNum = (int)nums[nums.Count - 1];
            nums[location] = lastNum;
            numToLocation[lastNum] = location;
            nums.RemoveAt(nums.Count - 1);
            numToLocation.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            Random random = new Random();
            int r = random.Next(nums.Count);
            return (int)nums[r];
        }
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */