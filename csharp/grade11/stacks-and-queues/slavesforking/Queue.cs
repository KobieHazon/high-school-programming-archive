using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slavesforking
{
    class Queue<T>
    {
        private Node<T> first;

        private Node<T> last;
        //-----------------------------------
        public Queue()
        {
            this.first = null;

            this.last = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return (this.first == null);
        }
        //-----------------------------------
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.first == null)

                this.first = temp;
            else

                this.last.SetNext(temp);

            this.last = temp;
        }
        //-------------------------------------
        public T Remove()
        {
            T x = this.first.GetInfo();

            first = first.GetNext();

            if (this.first == null)

                this.last = null;

            return (x);
        }
        //-------------------------------------
        public T Head()
        {
            return (this.first.GetInfo());
        }

        //-------------------------------------
        public void Reverse()
        {
            Stack<T> s = new Stack<T>();

            Node<T> pos = this.first;

            while (pos != null)
            {
                s.Push(pos.GetInfo());

                pos = pos.GetNext();
            }

            pos = this.first;

            while (pos != null)
            {
                pos.SetInfo(s.pop());

                pos = pos.GetNext();
            }


        }
        //-------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.first;

            while (pos != null)
            {
                st += pos.GetInfo();

                if (pos.GetNext() != null)

                    st += ",";

                pos = pos.GetNext();
            }
            st += "]";
            return (st);
        }
    }
}
