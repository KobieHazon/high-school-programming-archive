using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node<Michael>
    {
        private Michael info;
        private Node<Michael> next;

        public Node(Michael x)
        {
            this.info = x;
            this.next = null;
        }
        public Node(Michael x, Node<Michael> y)
        {
            this.info = x;
            this.next = y;
        }

        public Node<Michael> GetNext()
        {
            return this.next;
        }
        public Michael GetInfo()
        {
            return this.info;
        }

        public void SetNext(Node<Michael> x)
        {
            this.next = x;
        }
        public void SetInfo(Michael x)
        {
            this.info = x;
        }

        public override string ToString()
        {
            return ("the info is " + this.info);
        }
    }
}
