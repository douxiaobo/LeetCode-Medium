impl Solution {
    pub fn subsets(nums: Vec<i32>) -> Vec<Vec<i32>> {
        if nums.len()==0{
            return Vec::new();
        }

        let mut vecs:Vec<Vec<i32>>=Vec::new();
        let mut vec:Vec<i32>=Vec::new();
        backtrack(&mut vecs, &mut vec, &nums,0);
        return vecs;
    }
}

fn backtrack(vecs: &mut Vec<Vec<i32>>, vec: &mut Vec<i32>, nums: &Vec<i32>, start: usize) {
    //将路径记入结果 
    vecs.push(vec.clone());

    for i in start..nums.len(){
        //对应模板：做选择
        vec.push(nums[i]);

        //对应模板：将该选择从选择列表移除后递归调用
        backtrack(vecs, vec, &nums,i+1);

        //对应模板：撤销选择,将该选择
        vec.remove(vec.len()-1);
    }
}