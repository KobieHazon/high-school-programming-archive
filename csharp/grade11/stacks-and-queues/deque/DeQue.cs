using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeQue
{
    class DeQue<T>
    {
        private Node<T> Right;

        private Node<T> Left;
        //-----------------------------------
        public DeQue()
        {
            this.Right = null;

            this.Left = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return (this.Right == null);
        }
        //-----------------------------------
        public void InsertRight(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.Right == null)

                this.Right = temp;
            else

                this.Right.SetNext(temp);
        }
        public void InsertLeft(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.Left == null)

                this.Left = temp;
            else

                this.Left.SetNext(temp);
        }
        //-------------------------------------
        public T GetRemoveDEQUERight()
        {
            T x = this.Right.GetValue();
            Right = Right.GetNext();

            return x;
        }


        public T GetRemoveDEQUELeft()
        {
            T x = this.Left.GetValue();
            Left = Left.GetNext();
            return x;
        }
        
       
        //-------------------------------------
        public T GetHeadDEQUERight()
        {
            return this.Right.GetValue();
        }

        public T GetHeadDEQUELeft()
        {
            return this.Left.GetValue();
        }

        //-------------------------------------
        public void Reverse()
        {
            Stack<T> s = new Stack<T>();

            Node<T> pos = this.Right;

            while (pos != null)
            {
                s.Push(pos.GetValue());

                pos = pos.GetNext();
            }

            pos = this.Right;

            while (pos != null)
            {
                pos.SetInfo(s.Pop());

                pos = pos.GetNext();
            }


        }
        //-------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.Right;

            while (pos != null)
            {
                st += pos.GetValue();

                if (pos.GetNext() != null)

                    st += ",";

                pos = pos.GetNext();
            }
            st += "]";
            return (st);
        }
    }
}
