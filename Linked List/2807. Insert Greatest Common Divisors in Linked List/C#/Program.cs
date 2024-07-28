namespace C_;

class Program
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head == null || head.next == null) {  
            return head;  
        }
        ListNode current = head;
        while (current != null && current.next != null) {
            int gcdVal = GCD(current.val, current.next.val);
            ListNode newNode = new ListNode(gcdVal);
            newNode.next = current.next;
            current.next = newNode;
            current = newNode.next;
        }
        
        return head;
    }
    private int GCD(int a,int b){
        if (b == 0) return a;  
        return GCD(b, a % b); 
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
