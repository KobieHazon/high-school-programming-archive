using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static Node<int> MakerEnd()
        {
            Node<int> L1 = null;
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                L1 = new Node<int>(x, L1);
            }
            return L1;
        }


        public static Node<int> MakerStart()
        {
            Node<int> L1 = null;
            Node<int> pos = null;
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<int>(x);
                    pos = L1;
                }
                else
                {
                    pos.SetNext(new Node<int>(x));
                    pos = pos.GetNext();
                }
            }
            return L1;
        }

        public static void DeletePrev(Node<int> L, int x)
        {
            while (L.GetInfo() == x)
                 L = L.GetNext();
            Node<int> pos = L;
            while (pos != null)
            {
                if (pos.GetInfo() == x)
                {
                    if (pos.GetNext() == null)
                        pos.SetNext(null);
                    L.GetPrev(pos).SetNext(pos.GetNext());  
                }
                pos = pos.GetNext();
            }
        }
        //why doesnt it work?
        //in a test can i add a action to Node class?



        public static void Print(Node<int> L)
        {
            Node<int> pos = L;

            Console.Write(pos.GetInfo());
            pos = pos.GetNext();
            while (pos != null)
            {
                Console.Write(" -> " + pos + "");
                pos = pos.GetNext();
            }
        }

        //public static void DeleteValue(Node<int> L, int Value)
        //{
        //    Node<int> Save = L;
        //    Node<int> former = null;
        //    while (L != null)
        //    {
        //        if (L.GetInfo() == Value)
        //        {
        //            if (L == Save)
        //            {
        //                L = L.GetNext();
        //                Save = L;
        //            }
        //            else
        //                former.SetNext(L.GetNext());
        //        }
        //        former = L;
        //        L = L.GetNext();
        //    }
        //    L = Save;
        //}

        
        public static int SumChain(Node<int> L)
        {
            Node<int> pos = L;
            int sum = 0;
            while (pos != null)
            {
                sum = sum + pos.GetInfo(); // sum += pos.GetInfo();
                pos = pos.GetNext();
            }
            return sum;
        }

        public static int SumEven(Node<int> L)
        {
            Node<int> pos = L;
            int sum = 0;
            while (pos != null)
            {
                sum += pos.GetInfo();
                pos = pos.GetNext().GetNext();
            }

            return sum;
        }

        public static int Biggest(Node<int> L)
        {
            Node<int> pos = L;
            int temp = pos.GetInfo();

            while (pos != null)
            {
                if (temp < pos.GetInfo())
                    temp = pos.GetInfo();

                pos = pos.GetNext();
            }
            return temp;
        }
        public static bool IsExist(Node<int> L, int x)
        {
            Node<int> pos = L;
            while (pos != null)
            {
                if (x == pos.GetInfo())
                    return true;

                pos = pos.GetNext();
            }
            return false;
        }
        public static Node<int> ChainNoMultiple(Node<int> L)
        {
            Node<int> newL = null;
            Node<int> pos = L;
            int x = 0;

            while (pos != null)
            {
                x = pos.GetInfo();
                if (!(IsExist(newL, x)))
                {
                    newL = new Node<int>(x, newL);
                }
                pos = pos.GetNext();
            }
            return newL;

        }



        public static Node<int> Minus9(Node<int> n)
        {
            Node<int> pos = n;
            Node<int> newL = null;
            Node<int> posNew = null;
            int num = 0;
            while (pos != null)
            {
                if (pos.GetInfo() != -9)
                    num = (num * 10) + pos.GetInfo();
                else
                {
                    if (newL == null)
                    {
                        newL = new Node<int>(num);
                        posNew = newL;
                        num = 0;
                    }
                    else
                    {
                        posNew.SetNext(new Node<int>(num));
                        posNew = posNew.GetNext();
                        num = 0;
                    }
                }
                pos = pos.GetNext();
            }
            return newL;
        }


        static void Main(string[] args)
        {
            Node<int> L = MakerStart();
            Console.WriteLine("-------------------------");
            int x = int.Parse(Console.ReadLine());
            DeletePrev(L, x);
            Print(L);
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}


//public static Node<char> MakerStartC()
//{
//    Node<char> L1 = null;
//    Node<char> pos = null;
//    for (int i = 0; i < 10; i++)
//    {
//        char x = char.Parse(Console.ReadLine());
//        if (L1 == null)
//        {
//            L1 = new Node<char>(x);
//            pos = L1;
//        }
//        else
//        {
//            pos.SetNext(new Node<char>(x));
//            pos = pos.GetNext();
//        }
//    }
//    return L1;
//}
//public static bool IsExist(Node<Char> L, int x)
//{
//    Node<Char> pos = L;
//    while (pos != null)
//    {
//        if (x == pos.GetInfo())
//            return true;

//        pos = pos.GetNext();
//    }
//    return false;
//}

//public static void SameChainNoMultiple(Node<Char> L)
//{
//    Node<Char> Pos = L;
//    while (Pos != null)
//    {
//        char x = Pos.GetInfo();
//        if (IsExist(Pos, x) == true)
//        {

//        }
//        Pos = Pos.GetNext();
//    }
//}


//public static void SameChainNoMultiple(Node<int> L)
//{
//    Node<int> pos = L;
//    Node<int> former = null;
//    int x = 0;

//    while (L.GetNext() != null)
//    {

//    }
//    L = pos;

//}
