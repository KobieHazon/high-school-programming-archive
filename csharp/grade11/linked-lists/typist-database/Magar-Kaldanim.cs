using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace שאלה_3
{
    class Magar_Kaldanim
    {
        private Node<Kaldanit>[] Magar;

        public Magar_Kaldanim()
        {
            Magar = new Node<Kaldanit>[2];
            for (int i = 0; i < Magar.Length; i++)
            {
                Magar[i] = null;
            }
        }

        public void AddKaldanit(string Lang, Kaldanit K)
        {
            int x = 0;
            if (Lang == "Hebrew")
                 x = 1;

            Node<Kaldanit> Pos = Magar[x];

            if (Pos == null)
               Pos = new Node<Kaldanit>(K);
            else
            {
                while (Pos.GetNext() != null)
                    Pos = Pos.GetNext();
                
                Pos.SetNext(new Node<Kaldanit>(K));
            }
        }

        public int AverageWorks(string Lang)
        {
            int temp = 0;
            int counter = 0;
            int x = 0;
            if (Lang == "Hebrew")
                 x = 1;

            Node<Kaldanit> Pos = Magar[x];
            while (Pos !=null)
            {
                temp += Pos.GetValue().GetNumTypingJobs();
                counter++;
                Pos = Pos.GetNext();
            }
            return temp / counter;    
        }


        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < 2; i++)
            {
                Node<Kaldanit> pos = this.Magar[i];
                while (pos != null)
                {
                    str += pos.GetValue().ToString();
                    pos = pos.GetNext();
                }
            }
            return str;
        }
    }
}
