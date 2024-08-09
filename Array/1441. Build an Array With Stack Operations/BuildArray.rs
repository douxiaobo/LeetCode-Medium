fn build_array(target: Vec<i32>, n: i32) -> Vec<String> {
    let mut result = Vec::new();
    let mut index = 1;
    for &num in &target {
        while num > index {
            result.push("Push".to_string());
            result.push("Pop".to_string());
            index += 1;
        }
        result.push("Push".to_string());
        index += 1;
    }
    result
}

fn main() {
    let target = vec![1, 3];
    let n = 3;
    let result = build_array(target, n);
    println!("{:?}", result);
}