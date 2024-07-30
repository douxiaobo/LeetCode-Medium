impl Solution {
    pub fn min_partitions(n: String) -> i32 {
        let mut result = 0;
        for c in n.chars() {
            let current_digit = c as i32 - '0' as i32;
            if current_digit > 0 {
                if result < current_digit {
                    result = current_digit;
                }
            }
            if result == 9 {
                break;
            }
        }
        result
    }
}