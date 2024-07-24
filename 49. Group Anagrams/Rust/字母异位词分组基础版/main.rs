use std::collections::HashMap;

impl Solution {
    pub fn group_anagrams(strs: Vec<String>) -> Vec<Vec<String>> {
        let mut vecs:Vec<Vec<String>>=Vec::new();
        let mut used:Vec<bool>=vec![false;strs.len()];

        for i in 0..strs.len(){
            let mut temp:Vec<String>=Vec::new();
            if !used[i]{
                temp.push(strs[i].clone());
                for j in i+1..strs.len(){
                    let mut is_anagram:bool=true;
                    if strs[i].len()!=strs[j].len(){
                        continue;
                    }

                    let mut map=HashMap::new();

                    //计算strs[i]中每个字母的数量
                    for c in strs[i].chars(){
                        let count=map.entry(c).or_insert(0);
                        *count+=1;
                    }

                    //用strs[j]减少每个字母的数量
                    for c in strs[j].chars(){
                        let count=map.entry(c).or_insert(0);
                        *count-=1;

                        //如果计数器低于零，说明strs[j]包含一个不在strs[i]的字母，立即结束剩余字母的比较
                        if *count<0{
                            is_anagram=false;
                            break;
                        }
                    }

                    //如果是异位词，将该字符串标记为已用，同时加入动态数组 
                    if is_anagram{
                        used[j]=true;
                        temp.push(strs[j].clone());
                    }
                }
            }
            if !temp.is_empty(){
                vecs.push(temp);
            }
        }
        return vecs;
    }
}//Time Limit Exceeded