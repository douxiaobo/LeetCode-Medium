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
            public ListNode(int val=0,ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode head=new ListNode(4);
            head.next = new ListNode(2);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            Console.WriteLine(SortList(head));
            Console.ReadKey();
        }
        public static ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode head1 = head;
            ListNode head2 = split(head);
            head1 = SortList(head1);
            head2 = SortList(head2);
            return merge(head1, head2);
        }
        private static ListNode split(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode second = slow.next;
            slow.next = null;
            return second;
        }
        private static ListNode merge(ListNode head1, ListNode head2)
        {
            ListNode dummy = new ListNode(0);
            ListNode cur = dummy;
            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    cur.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    cur.next = head2;
                    head2 = head2.next;
                }
                cur = cur.next;
            }
            cur.next = head1 == null ? head2 : head1;
            return dummy.next;
        }
    }
}
