using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }
        static void Main(string[] args)
        {
            Node head1 = new Node();
            Node node1 = head1;
            Node prev1 = head1;

            Node head2 = new Node();
            Node node2 = head2;
            Node prev2 = head2;

            Node head3 = new Node();
            Node node3 = head3;
            Node prev3 = head3;

            //第三行
            node3.val = 11;
            node3 = node3.next;
            node3.val = 12;
            node3.prev = prev3;
            node3.next = null;

            //第二行
            node2.val = 7;
            node2 = node2.next;

            node2.val = 8;
            node2.prev = prev2;
            prev2 = prev2.next;
            node2.child = head3;
            node2 = node2.next;

            node2.val = 9;
            node2.prev = prev2;
            prev2 = prev2.next;
            node2 = node2.next;

            node2.val = 10;
            node2.prev = prev2;
            node2.next = null;

            //第一行
            node1.val = 1;
            node1.next = node1;

            node1.val = 2;
            node1.prev = prev1;
            prev1 = prev1.next;
            node1.next = node1;

            node1.val = 3;
            node1.prev = prev1;
            prev1 = prev1.next;
            node1.child = head2;
            node1.next = node1;

            node1.val = 4;
            node1.prev = prev1;
            prev1 = prev1.next;
            node1.next = node1;

            node1.val = 5;
            node1.prev = prev1;
            prev1 = prev1.next;
            node1.next = node1;

            node1.val = 6;
            node1.prev = prev1;
            node1.next = null;
        }
        public static Node Flatten(Node head)
        {
            flattenGetTail(head);
            return head;
        }
        private static Node flattenGetTail(Node head)
        {
            Node node = head;
            Node tail = null;       //可能做为尾部？我没明白，尾部有什么用处。
            while (node != null)
            {
                Node next = node.next;
                if (node.child != null)     //有child情况下
                {
                    Node child = node.child;
                    Node childTail = flattenGetTail(node.child);
                    node.child = null;      //child被删除
                    node.next = child;      //这两行互相连接
                    child.prev = node;
                    childTail.next = next;
                    if (next != null)
                    {
                        next.prev = childTail;
                    }
                    tail = childTail;
                }
                else
                {
                    tail = node;            //无child情况下
                }
                node = next;        //下一个
            }
            return tail;
        }
    }
}
