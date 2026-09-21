using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class tosses
    {
        private Node<toss> tosses1;
        private int numOftosss;

        public tosses()
        {
            this.tosses1 = null;
            this.numOftosss = 0;
        }

        public int mosttosses()
        {
            int bigcount = 0, bigi = 0;
            Node<toss> temp = this.tosses1;
            int[] arr = new int[6];
            while (temp != null)
            {
                arr[temp.GetInfo().GetToss1() - 1]++;
                arr[temp.GetInfo().GetToss2() - 1]++;
                temp = temp.GetNext();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > bigcount)
                {
                    bigcount = arr[i];
                    bigi = i;
                }
            }
            return bigi + 1;
        }
        public void AddFirst(toss t1)
        {
            this.tosses1 = new Node<toss>(new toss(t1), this.tosses1);
            this.numOftosss++;
        }


        public void Addlast(toss t1)
        {

            Node<toss> pos1 = this.tosses1;
                if (this.tosses1 == null)
                    this.tosses1 = new Node<toss>(new toss(t1));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<toss>(new toss(t1)));
                }
                this.numOftosss++;
        }

        public Node<toss> GetChain()
        {
            return this.tosses1;
        }

        public override String ToString()
        {
            String str = "";
            Node<toss> pos = this.tosses1;

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
