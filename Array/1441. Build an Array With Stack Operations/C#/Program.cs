namespace C_;
public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result=new List<string>();
        int index=1;
        for(int i=0;i<target.Length;i++){
            while(target[i]>index){
                result.Add("Push");
                result.Add("Pop");
                index++;
            }
            result.Add("Push");
            index++;
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Array/1441. Build an Array With Stack Operations/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Array/1441. Build an Array With Stack Operations/C#/C#.csproj (in 1.34 sec).
// 已成功还原。


// douxiaobo@192 C# % 