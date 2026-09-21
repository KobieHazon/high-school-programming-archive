using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int HowManyCanYouAdd(dominoList l1, domino d1)
        {
            Node<domino> tempList = l1.GetChain();
            domino tempDomino = d1;
            int count = 0;
            while (tempList != null)
            {
                if (tempList.GetInfo().InDomino(tempDomino.GetSide1()) || tempList.GetInfo().InDomino(tempDomino.GetSide2()))
                    count++;
                tempList = tempList.GetNext();
            }
            return count;
        }
        static dominoList randomnodes()
        {
            Random rnd = new Random();
            dominoList nodelist = new dominoList();
            for (int i = 0; i < 8; i++)
            {
                //node1 = AddNode(node1, new Node<int>(rnd.Next(1,11)));
                nodelist.Addlast(new domino((rnd.Next(0, 7)), (rnd.Next(0, 7))));
            }
            return nodelist;
        }
        static void Main(string[] args)
        {
            dominoList ts1 = randomnodes();
            Console.WriteLine(ts1);
            Random rnd = new Random();
            domino d1 = new domino((rnd.Next(0, 7)), (rnd.Next(0, 7)));
            Console.WriteLine(d1);
            Console.WriteLine(HowManyCanYouAdd(ts1, d1));
        }
    }
}
