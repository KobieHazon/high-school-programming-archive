using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;

        public Queue()
        {
            this.first = null;
            this.last = null;
        }

        public bool IsEmpty()
        {
            return this.first == null;
        }

        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);
            if (this.last == null)
                this.first = temp;
            else
            {
                this.last.SetNext(temp);
            }
            this.last = temp;
        }

        public T Remove()
        {
            T x = this.first.GetInfo();
            this.first = this.first.GetNext();
            if (this.first == null)
                this.last = null;
            return x;
        }

        public T Head()
        {
            return this.first.GetInfo();
        }

        public override string ToString()
        {
            string str = "[";

            Node<T> pos = this.first;
            while (pos != null)
            {
                if (pos.GetNext() == null)
                    str = str + pos.GetInfo();
                else
                    str = str + pos.GetInfo() + ", ";
                pos = pos.GetNext();
            }
            str = str + "]";
            return str;

        }
    }

}
