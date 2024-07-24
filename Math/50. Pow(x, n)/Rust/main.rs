impl Solution {
    pub fn my_pow(x: f64, n: i32) -> f64 {
        let mut x=x;
        let mut n=n;
        if n<0 {
          x=1.0/x;
          n=-n;
        }
        return fast_pow(x,n)
    }
}

fn fast_pow(x:f64, n:i32) ->f64 {
    //对应模板：递归终止条件
    if n==0 {
        return 1.0;
    }

    //对应模板：处理当前层逻辑
    //对应模板：下探到下一层，求解子问题
    let half=fast_pow(x,n/2);

    //对应模板：将子问题的结果合并成原问题的解
    return if n%2==0 {
        half*half
    } else {
        half*half*x
    }
}