using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collec_2014___2_
{
    class Collec
    {
        private Node<int> colec;

        public Collec()
        {
            colec = null;
        }
        public Collec(int n)
        {
            colec = new Node<int>(n);
        }

        public Node<int> GetCollec()
        {
            return this.colec;
        }

        public bool Add(int n)
        {
            Node<int> pos1 = this.colec;
            while (pos1.GetNext() != null)
            {
                pos1 = pos1.GetNext();
            }
            if (this.colec == null)
            {
                colec = new Node<int>(n);
                return true;
            }
            else
            {
                if (n > pos1.GetInfo())
                {
                    pos1.SetNext(new Node<int>(n));
                    return true;
                }
                else 
                {
                    return false;
                }
                
            }
            
        }
        public int small()
        {
            Node<int> pos = this.GetCollec();
            int smallest = pos.GetInfo();
            if (pos == null)
            {
                return -1;
            }
            else
            {
                while (pos != null)
                {
                    if (pos.GetInfo() < smallest)
                    {
                        smallest = pos.GetInfo();
                    }
                    pos = pos.GetNext();
                }
                return smallest;
            }
        }
        public int smallest(Collec c)
        {
            int x = c.small();
            int y = this.small();
            if (x > y)
                return y;
            else
                return x;
        }
   }

}

    


