#nullable enable
namespace Linked_List;

class Program
{
    public ListNode? MergeNodes(ListNode? head) {
        if (head == null || head.next == null)
            throw new ArgumentException("The input list is empty or invalid.", nameof(head));
        ListNode result=new ListNode();
        int sum=0;
        ListNode? current=result;
        while(head!=null){
            if(head.val>0){
                sum+=head.val;
            } else if(sum!=0) {
                current.next=new ListNode(sum);
                current=current.next;
                sum=0;
            }
            head=head.next;
        }
        return result.next;
    }
    static void Main(string[] args)
    {
        int[] arr = new int[] { 0, 3, 1, 0, 4, 5, 2, 0 };
        ListNode? head = null;
        ListNode? lastNode=null;

        foreach (var item in arr)
        {
            ListNode newNode = new ListNode(item);
            if(head==null){
                head=newNode;   // 第一个节点，成为head
            } else {
                lastNode!.next=newNode; // 将新节点添加到lastNode的后面
            }
            lastNode=newNode;   // 更新lastNode为新节点
        }

        // 调用MergeNodes方法
        var solution = new Program();
        ListNode? mergedHead = solution.MergeNodes(head);

        // 打印合并后的链表
        PrintList(mergedHead);
        
    }
    private static void PrintList(ListNode? head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }
    public class ListNode {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }
    }
}

// douxiaobo@192 Linked List % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Coding/LeetCode-Medium/Linked List/Linked List.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Coding/LeetCode-Medium/Linked List/Linked List.csproj (in 1.59 sec).
// 已成功还原。


// douxiaobo@192 Linked List % 
