using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class dominoList
    {
        private Node<domino> dominoes;
        private int numOftosss;

        public dominoList()
        {
            this.dominoes = null;
            this.numOftosss = 0;
        }


        public void Addlast(domino t1)
        {

            Node<domino> pos1 = this.dominoes;
            if (this.dominoes == null)
                this.dominoes = new Node<domino>(new domino(t1));
                else
                {
                
                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<domino>(new domino(t1)));
                }
                this.numOftosss++;
        }

        public Node<domino> GetChain()
        {
            return this.dominoes;
        }

        public override String ToString()
        {
            String str = "";
            Node<domino> pos = this.dominoes;

            while (pos != null)
            {
                //str = str + String.Format("%-20s %10s\n", pos.GetInfo());
                str = str +  pos.GetInfo()+"\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
