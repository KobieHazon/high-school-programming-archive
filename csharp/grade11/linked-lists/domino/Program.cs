using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domino
{
    class Program
    {
        public static int Attach(Node<Domino> D, Dominos Ds)
        {
            Node<Domino> pos = Ds.GetD();
            int cnt = 0;
            while (pos != null)
            {
                int x = pos.GetInfo().GetFirst();
                int y = pos.GetInfo().GetSecond();
                if (x == D.GetInfo().GetFirst() || x == D.GetInfo().GetSecond())
                {
                    cnt++;
                }
                if (y == D.GetInfo().GetFirst() || y == D.GetInfo().GetSecond())
                {
                    cnt++;
                }
                pos = pos.GetNext();
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            Random Rnd = new Random();
            Node<Domino> ExD = new Node<Domino>(new Domino(Rnd.Next(0, 7), Rnd.Next(0, 7)));
            Dominos Ds = new Dominos();
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Ds.AddFirst(Rnd.Next(0, 7), Rnd.Next(0, 7));
            Console.WriteLine(Ds.ToString());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(ExD);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine(Attach(ExD, Ds));

        }
    }
}
