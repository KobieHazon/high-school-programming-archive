using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Board
    {
        private Node<Modaa>[] boardT;

        public Board()
        {
            this.boardT = new Node<Modaa>[3];
            for (int i = 0; i < 3; i++)
            {
                this.boardT[i] = null;
            }
        }

        public void AddModaa(Modaa a)
        {
            int i = -1;

            switch (a.GetType())
            {
                case "Sport": i = 0;
            break;
                case "Actualy": i = 1;
                break;
                case "Others": i = 2;
                break;
            }
            Addlast(a, i);
         }

        public void Addlast(Modaa a, int i)
        {
            Node<Modaa> pos = this.boardT[i];
                if (this.boardT[i] == null)
                {
                    this.boardT[i] = new Node<Modaa>(a);
                }
                else
                {

                    while (pos.GetNext() != null)
                        pos = pos.GetNext();

                    pos.SetNext(new Node<Modaa>(a));
                }
            }
        public void Updater()
        {
            for (int i = 0; i < 3; i++)
            {
                Node<Modaa> pos = boardT[i];
                while (pos != null)
                {
                    if (pos.GetInfo().GetDays() > 7)
                    {
                        boardT[i] = boardT[i].GetNext();
                        pos = pos.GetNext();
                    }
                    else
                    {
                        pos = null;
                    }
                }
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                Node<Modaa> pos = this.boardT[i];
                while (pos != null)
                {
                    str += pos.GetInfo().ToString();
                    pos = pos.GetNext();
                }
            }
            return str;
        }



    }
}
