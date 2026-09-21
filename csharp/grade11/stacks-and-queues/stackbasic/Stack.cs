using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackBasic
{
    public class Stack<T>
    {
        private Node<T> First;

        public Stack()
        {
            this.First = null;
        }
        public void Reverse()
        {
            Stack<T> pos = new Stack<T>();
            while (!this.IsEmpty())
            {
                pos.Push(this.Pop());
            }
            this.First = pos.First;

        }
        public bool IsEmpty()
        {
            return (this.First == null);
        }

        public void Push(T x)
        {
            this.First = new Node<T>(x, First);
        }

        public T Pop()
        {
            T x = this.First.GetInfo();
            this.First = this.First.GetNext();
            return x;
        }

        public T Top()
        {
            return this.First.GetInfo();
        }

        public void reverse()
        {
            Stack<T> pos = new Stack<T>();
            while (!this.IsEmpty())
            {
                pos.Push(this.Pop());
            }
            this.First = pos.First;

        }

        public override string ToString()
        {
            string str = "[ ";
            Node<T> Pos = this.First;
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

        public T GetItemAt(int k)
        {
            Node<T> pos = this.First;
            int cnt = 1;
            T x = default(T);
            while (pos != null)
            {
                if (k == cnt)
                    x = pos.GetInfo();
                cnt++;
                pos = pos.GetNext();
            }
            return x;

        }
        public T RemoveItemAt(int k)
        {
            Node<T> pos = this.First;
            Node<T> pos2 = null;
            while (k > 1 && pos != null)
            {
                pos2 = pos;
                pos = pos.GetNext();
                k--;
            }
            if (k == 1 && pos != null)
            {
                if (pos2 == null)
                    this.First = pos.GetNext();
                else
                    pos2.SetNext(pos.GetNext());
                return pos.GetInfo();
            }
            return default(T);
        }



    }
}
