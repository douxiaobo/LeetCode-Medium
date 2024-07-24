namespace CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length==0){
            return -1;
        }

        int left=0;
        int right=nums.Length-1;

        while(left<=right){
            int mid=left+(right-left)/2;
            if(nums[mid]==target){
                return mid;
            } else if(nums[left]<=nums[mid]){
                if(target>=nums[left]&&target<nums[mid]){
                    right=mid-1;
                } else {
                    left=mid+1;
                }
            } else {
                if(target>nums[mid]&&target<=nums[right]){
                    left=mid+1;
                } else {
                    right=mid-1;
                }
            }
        }
        return -1;
    }
}