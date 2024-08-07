namespace C_;

public class Solution {
    public int[] FindArray(int[] pref) {
        int[] result=new int[pref.Length];
        result[0]=pref[0];
        for(int i=1;i<pref.Length;i++){   
            result[i]=pref[i-1]^pref[i];            
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Array/2433. Find The Original Array of Prefix Xor/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Array/2433. Find The Original Array of Prefix Xor/C#/C#.csproj (in 1.77 sec).
// 已成功还原。


// douxiaobo@192 C# % 