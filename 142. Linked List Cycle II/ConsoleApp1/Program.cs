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
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        static void Main(string[] args)
        {
        }
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode slow = head;
            ListNode fast = head.next.next;
            while (slow != null && fast != null)
            {
                if (slow == fast)
                {
                    return slow;
                }
                slow = slow.next;
                fast = fast.next;
                if (fast != null)
                {
                    fast = fast.next;
                }
            }
            return null;
        }//
        public ListNode DetectCycle1(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    ListNode ptr = head;
                    while (ptr != slow)
                    {
                        ptr = ptr.next;
                        slow = slow.next;
                    }
                    return ptr;
                }
            }
            return null;
        }//Runtime:93 ms Beats:61.64% Memory:40.7 MB Beats:51.4%
    }
}
