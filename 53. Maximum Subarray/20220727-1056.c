int maxSubArray(int* nums, int numsSize){
    int cur=0;
    int max=INT_MIN;
    for(int i=0;i<numsSize;i++)
    {
        if(cur<=0)
            cur=nums[i];
        else
            cur+=nums[i];
        if(cur>max)
            max=cur;
    }
    return max;
}