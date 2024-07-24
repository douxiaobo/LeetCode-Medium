impl Solution {
    pub fn search(nums: Vec<i32>, target: i32) -> i32 {
        if nums.len()==0 {
            return -1;
        }

        let mut left=0;
        let mut right=nums.len()-1;

        while left<=right {
            let mid=left+(right-left)/2;
            if nums[mid]==target {      //找到目标值
                return mid as i32;
            } else if nums[left]<=nums[mid] {   //前半部分有序
                if target>=nums[left] && target<nums[mid] { //在前半部分找
                    right=mid-1;
                } else {    //在后部分找
                    left=mid+1;
                }
            } else {    //后半部分有序
                if target>nums[mid] && target<=nums[right] {    //在后半部分找
                    left=mid+1;
                } else {    //在前半部分找
                    right=mid-1;
                }
            }
        }
        return -1;
    }
}