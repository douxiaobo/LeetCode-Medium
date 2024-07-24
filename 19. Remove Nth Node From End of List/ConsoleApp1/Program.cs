using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0,ListNode next=null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode();
            dummy.next = head;
            ListNode front = head, back = dummy;
            for (int i = 0; i < n; i++)
            {
                front = front.next;
            }
            while (front != null)
            {
                front = front.next;
                back = back.next;
            }
            back.next = back.next.next;
            return dummy.next;
        }//Runtime:94 ms Beats:19.43% Memory:38.9 MB Beats:44.51%
    }
}
