using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מינוס_1
{
    class Node<T>
    {
        T info;
        Node<T> next;
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
        public T Getinfo()
        {
            return this.info;
        }
        public void Setinfo(T Info)
        {
            this.info = Info;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetNext(Node<T> Next)
        {
            this.next = Next;
        }
        public override string ToString()
        {
            return (" " + this.info);
        }
    }
}
