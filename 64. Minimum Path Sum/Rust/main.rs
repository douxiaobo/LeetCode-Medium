impl Solution {
    pub fn min_path_sum(grid: Vec<Vec<i32>>) -> i32 {
        let m=grid.len();     //行数m
        if m==0 { return 0; }
        let n=grid[0].len();  //列数n
        if n==0 { return 0; }

        //储存中间状态，即从开始到网格任一位置matrix[i][j]处的最小路径和
        let mut states=vec![vec![0;n];m];
        let mut sum=0;

        //初始化states的第一列数据，即第一列的边界路径和
        for i in 0..m{
            sum+=grid[i][0];
            states[i][0]=sum;
        }

        sum=0;
        //初始化states的第一行数据，即第一行的边界路径和
        for j in 0..n {
            sum+=grid[0][j];
            states[0][j]=sum;
        }

        //依次计算states[i][j]
        for i in 1..m {     //遍历行
            for j in 1..n {     //遍历列
                //matrix[i][j]处的路径和等于states[i-1][j]和states[i][j-1]两者的较小值加上本身
                states[i][j]=grid[i][j]+states[i-1][j].min(states[i][j-1]);
            }
        }
        states[m-1][n-1]
    }
}