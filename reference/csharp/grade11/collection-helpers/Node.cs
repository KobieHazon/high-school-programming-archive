using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Node_T
{
    class Node<T>
    {
        private T Value;
        private Node<T> next;
        public Node(T value)
        {
            this.Value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.Value = value;
            this.next = next;
        }
        public T GetValue()
        {
            return this.Value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetInfo(T value)
        {
            this.Value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public boolean hasNext()
        {
            return this.GetNext() != null;

        }
        public override string ToString()
        {
            return "" + this.Value;
        }
    }
}
