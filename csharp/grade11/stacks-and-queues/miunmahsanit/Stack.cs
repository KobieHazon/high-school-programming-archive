using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miunmahsanit
{
    class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }
        public bool IsEmpty()
        {
            return (this.first == null);
        }
        public void Push(T x)
        {
            this.first = new Node<T>(x, first);
        }
        public T pop()
        {
            T X = this.first.GetInfo();
            this.first = this.first.GetNext();
            return X;
        }
        public T top()
        {
            return this.first.GetInfo();
        }
        public void reverse()
        {
            Stack<T> pos = new Stack<T>();
            while (!this.IsEmpty())
            {
                pos.Push(this.pop());
            }
            this.first = pos.first;

        }
        public override string ToString()
        {
            string str = "[ ";
            Node<T> Pos = this.first;
            while (Pos != null)
            {
                str = str + Pos.GetInfo().ToString();
                if (Pos.GetNext() != null)
                    str = str + " , ";
                Pos = Pos.GetNext();
            }
            str = str + "]";
            return (str);
        }
    }
}
