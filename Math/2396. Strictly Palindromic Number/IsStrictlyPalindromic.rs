struct Solution;

impl Solution {
    pub fn is_strictly_palindromic(n: i32) -> bool {
        for base_num in 2..=n - 2 {
            if !Self::is_palindrome_in_base(n, base_num) {
                return false;
            }
        }
        true
    }

    fn is_palindrome_in_base(num: i32, base_num: i32) -> bool {
        let num_str = Self::convert_to_base(num, base_num);
        let mut left = 0;
        let mut right = num_str.len() - 1;
        while left < right {
            if num_str.chars().nth(left) != num_str.chars().nth(right) {
                return false;
            }
            left += 1;
            right -= 1;
        }
        true
    }

    fn convert_to_base(num: i32, base_num: i32) -> String {
        if num == 0 {
            return "0".to_string();
        }
        let mut num = num;
        let mut result = String::new();
        while num > 0 {
            let remainder = num % base_num;
            result.insert(0, std::char::from_digit(remainder as u32, 10).unwrap());
            num /= base_num;
        }
        result
    }
}

fn main() {
    let solution = Solution;
    println!("{}", solution.is_strictly_palindromic(9)); // 示例测试
}