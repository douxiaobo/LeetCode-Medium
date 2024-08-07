namespace C_;
public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        for (int baseNum = 2; baseNum <= n - 2; baseNum++) {  
            if (!IsPalindromeInBase(n, baseNum)) {  
                return false;  
            }  
        }  
        return true;  
    }
    private bool IsPalindromeInBase(int num, int baseNum) {  
        // 将数字转换为指定进制的字符串  
        string numStr = ConvertToBase(num, baseNum);  
        // 检查字符串是否为回文  
        int left = 0, right = numStr.Length - 1;  
        while (left < right) {  
            if (numStr[left] != numStr[right]) {  
                return false;  
            }  
            left++;  
            right--;  
        }  
        return true;  
    }  
  
    // 辅助函数：将数字转换为指定进制的字符串  
    private string ConvertToBase(int num, int baseNum) {  
        if (num == 0) return "0";  
        var sb = new StringBuilder();  
        while (num > 0) {  
            int remainder = num % baseNum;  
            sb.Insert(0, remainder.ToString());  
            num /= baseNum;  
        }  
        return sb.ToString();  
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Math/2396. Strictly Palindromic Number/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Math/2396. Strictly Palindromic Number/C#/C#.csproj (in 694 ms).
// 已成功还原。


// douxiaobo@192 C# % 