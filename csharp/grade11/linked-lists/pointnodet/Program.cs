using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointNodeT
{
    class Program
    {
        public static Node<Point> MakerStart()
        {
            Node<Point> L1 = null;
            Node<Point> pos = null;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("_______________");
                double x = int.Parse(Console.ReadLine());
                double y = int.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<Point>(new Point(x, y));
                    pos = L1;
                }
                else
                {
                    pos.SetNext(new Node<Point>(new Point(x, y)));
                    pos = pos.GetNext();
                }
            }
            return L1;
        }



        public static void Print(Node<Point> L)
        {
            Node<Point> pos = L;

            Console.Write(pos.GetInfo());
            pos = pos.GetNext();
            while (pos != null)
            {
                Console.Write(" -> " + pos.GetInfo().ToString() + "");
                pos = pos.GetNext();
            }
        }

        public static Node<Point> NotBigger(Node<Point> L)
        {
            Node<Point> Pos = L;
            Node<Point> New = null;
            Node<Point> NewPos = null;
            while (Pos != null)
            {
                if ((Pos.GetInfo().GetX() + Pos.GetInfo().GetY()) <= 20)
                {
                    if (New == null)
                    {
                        New = new Node<Point>(new Point(Pos.GetInfo().GetX(), Pos.GetInfo().GetY()));
                        NewPos = New;
                    }
                    else
                    {
                        New.SetNext(new Node<Point>(new Point(Pos.GetInfo().GetX(), Pos.GetInfo().GetY())));
                        New = New.GetNext();
                    }
                }
                Pos = Pos.GetNext();
            }
            return NewPos;
        }

        public static Point Highest(Node<Point> L)
        {
            Node<Point> Pos = L;
            Point HighestP = L.GetInfo();
            while (L != null)
            {
                if (L.GetInfo().GetY() > HighestP.GetY())
                {
                    HighestP = L.GetInfo();
                }
                L = L.GetNext();
            }
            L = Pos;
            return HighestP;

        }

        static void Main(string[] args)
        {
            Node<Point> P = MakerStart();
            P = NotBigger(P);
            Print(P);
            Point HighestP = Highest(P);
            Console.WriteLine(HighestP.ToString());

        }
    }
}
