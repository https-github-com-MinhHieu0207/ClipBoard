using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoard
{
    public class Node
    {
        public Node next;
        public object data;
    }
    public class MyStack
    {
        Node top;
        public bool IsEmpty()
        {
            return top == null;
        }
        public void Push(object ele)
        {
            Node n = new Node();
            n.data = ele;
            n.next = top;
            top = n;
        }
        public Node Pop()
        {
            if (top == null)
                return null;
            Node d = top;
            top = top.next;
            return d;
        }

    }
}
