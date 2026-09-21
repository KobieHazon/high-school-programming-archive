using System;

using System.Text;

namespace ConsoleApplication1
{
    class List<T>
    {
        private Node<T> first;
//--------------------------------
        public List()
        {
            this.first = null;
        }
//--------------------------------
        public Node<T> GetFirst()
        {
            return (this.first);
        }
//--------------------------------
        public bool IsEmpty()
        {
            return (this.first==null);
        }
//--------------------------------
        public Node<T> Insert(Node<T> pos, T x)
        {
            Node<T> temp= new Node<T>(x);

            if(pos==null)
            {
                temp.SetNext(this.first);
                
                this.first=temp;
            }
            else
            {
                temp.SetNext(pos.GetNext());

                pos.SetNext(temp);
            }

            return (temp);
        }
//----------------------------------------
        public Node<T> Remove(Node<T> pos)
        {
            if (this.first == pos)

                this.first = pos.GetNext();
            else
            {
                Node<T> prevPos = this.GetFirst();

                while (prevPos.GetNext() != pos)

                    prevPos = prevPos.GetNext();

                prevPos.SetNext(pos.GetNext());
            }

            Node<T> nextPos = pos.GetNext();

            pos.SetNext(null);

            return (nextPos);
        }
//-----------------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.GetFirst();

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
