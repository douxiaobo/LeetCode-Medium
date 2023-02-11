int maxSubArray(int* nums, int numsSize){
    int cur=nums[0];
    int max=nums[0];
    for(int i=1;i<numsSize;i++)
    {
        if(cur+nums[i]>nums[i])
        {
            cur+=nums[i];
        }
        else
        {
            cur=nums[i];
        }
        if(max<cur)
        {
            max=cur;
        }
    }
    return max;
}