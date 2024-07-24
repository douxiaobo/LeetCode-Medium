using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode l1=new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            ListNode list = AddTwoNumbers(l1, l2);
            while(list!=null)
            {
                Console.WriteLine(list.val+" ");
            }
            Console.ReadKey();
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int plus = 0;
            ListNode res = new ListNode();
            ListNode node = res;
            while (l1 != null || l2 != null)
            {
                int x = 0;
                if (l1 != null)
                {
                    x = l1.val;
                    l1 = l1.next;
                }
                int y = 0;
                if (l2 != null)
                {
                    y = l2.val;
                    l2 = l2.next;
                }
                int num = x + y + plus;
                if (num > 9)
                {
                    plus = 1;
                    num -= 10;
                }
                else
                {
                    plus = 0;
                }
                node.next = new ListNode(num);
                node = node.next;
            }
            if (plus == 1)
            {
                node.next = new ListNode(1);
            }
            return res.next;
        }
    }
}
