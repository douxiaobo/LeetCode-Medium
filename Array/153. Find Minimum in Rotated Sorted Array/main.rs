impl Solution {
    pub fn find_min(nums: Vec<i32>) -> i32 {
        if nums.len()==1 {
            return nums[0];
        }

        let mut left=0;
        let mut right=nums.len()-1;

        //检验数据是否被旋转
        if nums[right]>nums[0] {
            return nums[0];
        }

        while left<=right {
            let mid=left+(right-left)/2;

            // nums[mid]>nums[mid+1]，nums[mid+1]是最小值
            if nums[mid]>nums[mid+1] {
                return nums[mid+1];
            }

            // nums[mid-1]>nums[mid]，nums[mid]是最小值
            if nums[mid-1]>nums[mid] {
                return nums[mid];
            }

            if nums[mid]>nums[0] {
                // nums[mid]>nums[0]，去mid左边搜索
                left=mid+1;
            } else{
                // nums[mid]<nums[0]，去mid右边搜索
                right=mid-1;
            }
        }
        return -1;
    }
}