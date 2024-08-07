namespace C_;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        node.val=node.next.val;
        node.next=node.next.next;
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Linked List/237. Delete Node in a Linked List/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Medium/Linked List/237. Delete Node in a Linked List/C#/C#.csproj (in 65 ms).
// 已成功还原。


// douxiaobo@192 C# % 