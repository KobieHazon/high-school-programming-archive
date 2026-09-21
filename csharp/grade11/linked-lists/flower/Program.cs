using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flower
{
    class Program
    {
        public static int Flower(Node<int> L)
        {
            int cnt = 0;
            Node<int> pos = L;

            while (pos != null)
            {
                if (CheckF(pos) == true)
                {
                    return cnt;
                }
                cnt++;
                pos = pos.GetNext();
            }
            return -1;
        }

        public static bool CheckF(Node<int> L)
        {
            Node<int> pos = L;
            int diff = pos.GetInfo();
            for (int i = 0; i < diff; i++)
            {
                pos = pos.GetNext();
                if ((pos.GetNext().GetInfo() - pos.GetInfo()) != diff)
                {
                    return false;
                }
                
            }
            return true;
        }

        static void Main(string[] args)
        {
            Node<int> Num = new Node<int>(21, new Node<int>(31, new Node<int>(4, new Node<int>(3, new Node<int>(2, new Node<int>(5, new Node<int>(8, new Node<int>(11, new Node<int>(7, new Node<int>(-4))))))))));
            Node<int> Pos = Num;
            while (Pos != null)
            {
                Console.WriteLine(Pos.GetInfo());
                Pos = Pos.GetNext();
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Flower(Num));
        }
    }
}
