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
                this .next = next;
            }
        }
        static void Main(string[] args)
        {
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            l1 = reverseList(l1);
            l2 = reverseList(l2);
            ListNode reverseHead = addReversed(l1, l2);
            return reverseList(reverseHead);
        }
        public ListNode reverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            return prev;
        }
        private ListNode addReversed(ListNode head1, ListNode head2)
        {
            ListNode dummy = new ListNode(0);
            ListNode sumNode = dummy;
            int carry = 0;
            while (head1 != null || head2 != null)
            {
                int sum = (head1 == null ? 0 : head1.val) + (head2 == null ? 0 : head2.val) + carry;
                carry = sum >= 10 ? 1 : 0;
                sum = sum >= 10 ? sum - 10 : sum;
                ListNode newNode = new ListNode(sum);
                sumNode.next = newNode;
                sumNode = sumNode.next; ;
                head1 = head1 == null ? null : head1.next;
                head2 = head2 == null ? null : head2.next;
            }
            if (carry > 0)
            {
                sumNode.next = new ListNode(carry);
            }
            return dummy.next;
        }//Runtime:96 ms Beats:73.83% Memory:49.8 MB Beats:53.27%
    }
}
