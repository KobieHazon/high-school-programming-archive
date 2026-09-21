using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domino
{
    class Dominos
    {
        private Node<Domino> D;

        public Dominos()
        {
            this.D = null;
        }

        public void AddFirst(int n1, int n2)
        {
            Random Rnd = new Random();
            this.D = new Node<Domino>(new Domino(n1, n2), this.D);
        }

        public Node<Domino> GetD()
        {
            return this.D;
        }

        public override String ToString()
        {
            String str = "";
            Node<Domino> pos = this.D;

            while (pos != null)
            {
                str = str + pos.GetInfo().ToString() + "\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
