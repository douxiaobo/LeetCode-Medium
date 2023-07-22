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
        }
        public Node Flatten(Node head)
        {
            flattenGetTail(head);
            return head;
        }
        private Node flattenGetTail(Node head)
        {
            Node node = head;
            Node tail = null;
            while (node != null)
            {
                Node next = node.next;
                if (node.child != null)
                {
                    Node child = node.child;
                    Node childTail = flattenGetTail(node.child);
                    node.child = null;
                    node.next = child;
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
                    tail = node;
                }
                node = next;
            }
            return tail;
        }
    }
}
