using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Node<T>
    {
        private T info;
        private Node<T> Next;
        
        public Node(T info)
        {
            this.info = info;
            this.Next=null;             
        }
        public Node(T info, Node<T> Next)
        {
            this.info = info;
            this.Next = Next;
        }
        public T GetInfo()
        {
            return this.info;
        }
        public Node<T> GetNext()
        {
            return this.Next;
        }
        public void SetInfo(T info)
        {
            this.info = info;
        }
        public void SetNext(Node<T> Next)
        {
            this.Next = Next;
        }
        public override string ToString()
        {
            return ("The info is " + this.info);
        }
    }
}
