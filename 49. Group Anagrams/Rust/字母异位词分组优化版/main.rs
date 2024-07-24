use std::collections::HashMap;

impl Solution {
    pub fn group_anagrams(strs: Vec<String>) -> Vec<Vec<String>> {
        let mut vecs:Vec<Vec<String>>=Vec::new();
        let mut map:HashMap<String,Vec<String>>=HashMap::new();

        for i in 0..strs.len(){
            //将字符串转换为字符计数
            let mut count=[0;26];
            for c in strs[i].chars(){
                let index=(c as u32-'a' as u32) as usize;
                count[index]+=1;
            }

            //字符数用“#”分隔组成字符串
            let mut chars=vec![];
            for i in 0..count.len(){
                chars.push(count[i].to_string()+"#");
            }
            let key:String=chars.into_iter().collect();

            //以26个字母字符数与“#”组成的字符串为键在HashMap中进行查找
            let value=map.get(&key);
            if value!=None{
                //找到对应值（字符串动态数组），将当前字符串压入并更新HashMap的键-值对
                let mut v=value.unwrap().to_vec();
                v.push(strs[i].clone());
                map.insert(key,v);
            } else {
                //未找到对应值，创建以当前字符串初始化的动态数组，并组成键-值对插入HashMap
                let v=vec![strs[i].clone()];
                map.insert(key,v);
            }
        }
        //迭代HashMap的所有值，每个值对应一组异位词
        for val in map.values(){
            vecs.push((*val).clone());
        }
        
        return vecs;
    }
}