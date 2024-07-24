impl Solution {
    pub fn minimum_total(triangle: Vec<Vec<i32>>) -> i32 {

        let mut result=triangle.clone();

        if result.len()==0 { return 0; }

        //从倒数第二行开始依次向上遍历
        for i in (0..result.len()-1).rev() {
            for j in 0..result[i].len() {
                result[i][j]=result[i][j]+result[i+1][j].min(result[i+1][j+1]);
            }
        }
        result[0][0]
    }
}


impl Solution {
    pub fn minimum_total(mut triangle: Vec<Vec<i32>>) -> i32 {
        if triangle.len()==0 { return 0; }

        //从倒数第二行开始依次向上遍历
        for i in (0..triangle.len()-1).rev() {
            for j in 0..triangle[i].len() {
                triangle[i][j]=triangle[i][j]+triangle[i+1][j].min(triangle[i+1][j+1]);
            }
        }
        triangle[0][0]
    }
}