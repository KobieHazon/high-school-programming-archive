using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberNode
{
    class Program
    {
        public static Node<int> maker() // פעולה שיוצרת שרשרת חוליות 
        {
            Node<int> L1 = null;
            Node<int> L2 = null;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                int x = int.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<int>(x);
                    L2 = L1;
                }
                else
                {
                    L2.SetNext(new Node<int>(x, null));
                    L2 = L2.GetNext();
                }
            }
            return L1;
        }
       
        public static bool IsExist(Node<int> Nums, int number) // בודקת אם המספר קיים במערך
        {
            Node<int> pos = Nums;
            while (pos != null)
            {
                if (pos.GetInfo() == number)
                {
                    return true;
                }
                pos = pos.GetNext();
            }
            return false;
        }
  
        public static void Print(Node<int> a) // פעולה שמדפיסה שרשרת מטיפוס מספרים שלמים
        {
            Node<int> pos = a;
            while (pos != null)
            {
                Console.Write(pos.GetInfo() + "");
                if (pos.GetNext() != null)
                {
                    Console.Write(" --> ");
                }
                pos = pos.GetNext();
            }
            Console.WriteLine("");
        }

        public static void PrintNumber(Node<NumberNode> L)
        {
            string str = "";
            Node<NumberNode> pos = L;
            while (pos != null)
            {
                str += pos.GetInfo().ToString() + "\n";
                pos = pos.GetNext();
            }
            Console.WriteLine(str);
        }

        public static Node<NumberNode> NewList(Node<int> L, Node<int> L1)
        {
            Node<int> pos = L;
            Node<int> pos1 = L1;
            NodeNumber NewList = new NodeNumber();
            int cnt = 0;
            int NewNum = 0;

            while (pos1 != null)
            {
                pos = L;
                
                if (pos1.GetInfo() != 0)
                {
                    for (int i = 1; i < pos1.GetInfo(); i++)
                        pos = pos.GetNext();
                    NewNum = (NewNum * 10) + pos.GetInfo();
                    cnt++;
                }
                
                else
                {
                    if (pos1.GetNext() == null)
                    {
                        for (int i = 0; i < pos1.GetInfo(); i++)
                            pos = pos.GetNext();
                        NewNum = (NewNum * 10) + pos.GetInfo();
                        cnt++;
                        NewList.Addlast(new NumberNode(NewNum, cnt));
                        return NewList.GetNode();
                    }
                    else
                    {
                        NewList.Addlast(new NumberNode(NewNum, cnt));
                        NewNum = 0;
                        cnt = 0;
                    }
                    
                }
                pos1 = pos1.GetNext();
            }
            return NewList.GetNode();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter for L:");
            Node<int> L = maker();
            Console.WriteLine("Enter for L1:");
            Node<int> L1 = maker();

            Node<NumberNode> NewNode = NewList(L, L1);
            PrintNumber(NewNode);

        }
    }
}
