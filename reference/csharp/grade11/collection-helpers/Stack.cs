using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }

        public bool IsEmpty()
        {
            return this.first == null;
            
        }

        public void Push(T x)
        {
            this.first = new Node<T>(x, this.first);
        }

        public T Pop()
        {
            T x = this.first.GetInfo();
            this.first = this.first.GetNext();

            return x;
        }

        public T Top()
        {
            return this.first.GetInfo();
        }

        public override string ToString()
        {
            string str = "[";

            Node<T> pos = this.first;
            while (pos != null)
            {
                str = str + pos.GetInfo().ToString();
                if (pos.GetNext() != null)
                    str = str += ",";
                pos = pos.GetNext();
            }
            str = str + "]";
            return str;
        }

    }
}
