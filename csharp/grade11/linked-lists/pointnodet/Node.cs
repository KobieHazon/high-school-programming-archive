using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointNodeT
{
    class Node<T>
    {
        private T info;
        private Node<T> next;

        public Node(T info)
        {
            this.info = info;
            next = null;
        }
        public Node(T info, Node<T> next)
        {
            this.info = info;
            this.next = next;
        }
        public T GetInfo()
        {
            return info;
        }
        public Node<T> GetNext()
        {
            return next;
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
            return this.info.ToString();
        }
        //public Node<T> GetPrev(Node<T> pos)
        //{
        //    if (pos.GetNext() == null)
        //        return null;

        //}

    }
}
