using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node<T>
    {
        private T info;
        private Node<T> next;

        public Node(T info)
        {
            this.info = info;
        }
        public Node(T info, Node<T> n)
        {
            this.info = info;
            this.next = n;
        }
        public Node<T> GetIN()
        {
            return this.next;
        }
        public T GetInfo()
        {
            return this.info;
        }
        public void SetIN(Node<T> n)
        {
            this.next = n;
        }
        public void SetInfo(T i)
        {
            this.info = i;
        }
        public override string ToString()
        {
            return this.info + "   -   ";
        }

    }
}
