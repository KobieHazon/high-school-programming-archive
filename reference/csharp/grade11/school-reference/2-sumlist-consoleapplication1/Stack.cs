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

        public Stack<T> Reverse(Stack<T> st1)
        {
            Stack<T> st2 = new Stack<T>();
            Stack<T> st3 = new Stack<T>();
            while (!st1.IsEmpty())
            {
                st2.Push(st1.Pop());
            }
            while (!st2.IsEmpty())
            {
                st3.Push(st2.Pop());
            }
            return st3;
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
