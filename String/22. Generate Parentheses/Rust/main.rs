impl Solution {
    pub fn generate_parenthesis(n: i32) -> Vec<String> {
        let mut vec: Vec<String>= Vec::new();
        recursion(&mut vec,0,0,n,String::from(""));
        return vec;
    }
}

fn recursion(vec: &mut Vec<String>, left: i32, right: i32, n:i32, s:String){
    //对应模板：递归终止条件
    //左括号和右括号都为n时添加这个答案
    if left==n && right==n {
        vec.push(s.clone());
    }

    //对应模板：下探到下一层
    //左括号个数小于n，可继续加左括号
    if left<n {
        recursion(vec, left+1, right, n, format!("{}{}",&s,"("));
    }

    //对应模板：下探到下一层
    //左括号个数大于右括号个数，可继续加右括号
    if right<left {
        recursion(vec, left, right+1, n, format!("{}{}",&s,")"));
    }
}