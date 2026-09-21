using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OriBachar_Node3
{
    class Node<T>
    {
        private T info;

        private Node<T> next;

        public Node(T info)
        {
            this.info = info;

            this.next = null;
        }

        public Node(T info, Node<T> next)
        {
            this.info = info;

            this.next = next;
        }

        public T GetInfo()
        {
            return (this.info);
        }

        public Node<T> GetNext()
        {
            return (this.next);
        }

        public void SetInfo(T info)
        {
            this.info = info;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            return ("The info is:" + this.info);
        }

    }
}
