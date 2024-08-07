impl Solution {
    pub fn find_array(pref: Vec<i32>) -> Vec<i32> {
        let mut result = vec![0; pref.len()];
        result[0] = pref[0];
        for i in 1..pref.len() {
            result[i] = pref[i-1] ^ pref[i];
        }
        result
    }
}