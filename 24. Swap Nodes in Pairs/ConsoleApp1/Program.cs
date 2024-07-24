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
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummyHead = new ListNode();
            dummyHead.next = head;
            ListNode cur = dummyHead;
            while (cur.next != null && cur.next.next != null)
            {
                ListNode tmp = cur.next;
                ListNode tmp1 = cur.next.next.next;
                cur.next = cur.next.next;
                cur.next.next = tmp;
                cur.next.next.next = tmp1;
                cur = cur.next.next;
            }
            return dummyHead.next;
        }//Runtime：81 ms Beats：80.29% Memory：37.9 MB Beats：75.77% 
        public ListNode SwapPairs1(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode nextNode = head.next;
            head.next = SwapPairs1(nextNode.next);
            nextNode.next = head;
            return nextNode;
        }//Runtime：76 ms Beats：93.49% Memory：38.1 MB Beats：45.93%
    }
}
