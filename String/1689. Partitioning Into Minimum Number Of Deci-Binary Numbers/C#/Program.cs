namespace C_;

public class Solution {
    public int MinPartitions(string n) {
        int result=0;
        for(int i=0;i<n.Length;i++){
            if(n[i]-'0'>0){
                if(result<n[i]-'0'){
                    result=n[i]-'0';
                }
            }
            if(result==9){
                break;
            }
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


// Last login: Tue Jul 30 17:32:33 on ttys000
// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/String/1689. Partitioning Into Minimum Number Of Deci-Binary Numbers/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/String/1689. Partitioning Into Minimum Number Of Deci-Binary Numbers/C#/C#.csproj (in 1.36 sec).
// 已成功还原。


// douxiaobo@192 C# % 
