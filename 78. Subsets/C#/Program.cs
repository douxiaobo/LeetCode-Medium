namespace C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> vecs=new List<IList<int>>();
        List<int> vec=new List<int>();
        if(nums.Length==0){
            return vecs;
        }
        backtrack(vecs,vec,nums,0);
        return vecs;
    }
    public void backtrack(IList<IList<int>> vecs, List<int> vec, int[] nums, int start){
        vecs.Add(new List<int>(vec));
        for(int i=start;i<nums.Length;i++){
            vec.Add(nums[i]);
            backtrack(vecs,vec,nums,i+1);
            vec.RemoveAt(vec.Count-1);
        }
    }
}