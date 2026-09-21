using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum3Lists
{
    class Program
    {
        public static Node<int> Sum(Node<int> L, Node<DuoInt> L2)
        {
            Node<int> pos = L;
            Node<DuoInt> pos2 = L2;
            Node<int> newL = null;
            int sum = 0;
            while (pos2 != null)
            {   
                pos = L;
                sum = 0;
                if (BorderCheck(pos, pos2.GetInfo().Get1(), pos2.GetInfo().Get2()) == true)
                {
                    for (int i = 0; i < pos2.GetInfo().Get1(); i++)
                        pos = pos.GetNext();
                    
                    for (int j = 0; j <= (pos2.GetInfo().Get2() - pos2.GetInfo().Get1()); j++)
                    {
                        sum += pos.GetInfo();
                        pos = pos.GetNext();
                    }
                    newL = new Node<int>(sum, newL);
                 }
                pos2 = pos2.GetNext();
                    
                }
            return newL;
        }

        public static bool BorderCheck(Node<int> L, int B1, int B2)
        {
            int max = 0;
            Node<int> pos = L;
            while (pos != null)
            {
                max++;
                pos = pos.GetNext();
            }
            if (B1 < 0 || B2 > max)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Node<int> L = new Node<int>(2, new Node<int>(4, new Node<int>(6, new Node<int>(8, new Node<int>(10, new Node<int>(12, new Node<int>(14)))))));
            Node<int> pos = L;
            while (pos != null)
            {
                Console.WriteLine(pos.GetInfo());
                pos = pos.GetNext();
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Node<DuoInt> L2 = new Node<DuoInt>(new DuoInt(1, 4), new Node<DuoInt>(new DuoInt(2, 3), new Node<DuoInt>(new DuoInt(1, 2), new Node<DuoInt>(new DuoInt(2, 4)))));
            Node<DuoInt> pos2 = L2;
            while (pos2 != null)
            {
                Console.WriteLine(pos2.GetInfo().ToString());
                pos2 = pos2.GetNext();
            }

            Node<int> sum = Sum(L, L2);
            Node<int> posS = sum;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (posS != null)
            {
                Console.WriteLine(posS.GetInfo());
                posS = posS.GetNext();
            }


        }
    }
}
