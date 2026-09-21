using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> L1 = null;

            //Console.WriteLine("sum : " + sum(Maker()));
            L1 = MakerStart();
            Print(L1);
            //Print(L1);
            //int totalNode = sum(L1);
           // int maxNode = biggest(L1);
           // Console.WriteLine("Total Node: " + totalNode + " Max : " + maxNode);
            // Console.WriteLine("biggest : " + biggest(Maker()))
            //Print(CopyOption2(L1));
            Console.WriteLine("");
            Node<int> L2 = Create(L1);
            Print(L2);

        }
        public static Node<int> MakerEnd()
        {
            Node<int> L1 = null;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
                int x = int.Parse(Console.ReadLine());
                L1 = new Node<int>(x, L1);
            }
            return L1;
        }
        public static Node<int> MakerStart()
        {
            Node<int> L1 = null;
            Node<int> pos = null;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
                int x = int.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<int>(x);
                    pos = L1;
                }
                else
                {
                    pos.SetIN(new Node<int>(x));
                    pos = pos.GetIN();
                }
            }
            return L1;
        }
        public static int sum(Node<int> n)
        {
            Node<int> Pos = n;
            int sum = 0;
            while (Pos != null)
            {
                sum += Pos.GetInfo();
                Pos = Pos.GetIN();
            }
            return sum;
        }
        public static int biggest(Node<int> n)
        {
            Node<int> Pos = n;
            int max = Pos.GetInfo();
            while (Pos != null)
            {
                if (Pos.GetInfo() > max)
                {
                    max = Pos.GetInfo();
                }
                Pos = Pos.GetIN();
            }
            return max;
        }
        public static void Print(Node<int> n)
        {
            Node<int> Pos = n;
            while (Pos != null)
            {
                Console.Write(Pos.ToString());
                Pos = Pos.GetIN();
            }
        }
        public static Node<int> Copy(Node<int> n)
        {
            Node<int> pos = n;
            Node<int> copied = null;
            Node<int> bkCopied = copied;
            bool isRepeated = true;
            while (pos != null)
            {
                isRepeated = true;
                while (bkCopied != null && isRepeated == true)
                {
                    if (bkCopied.GetInfo() != pos.GetInfo())
                    {
                        isRepeated = true;
                    }
                    else
                    {
                        isRepeated = false;
                    }
                    bkCopied = bkCopied.GetIN();
                }

                if (isRepeated)
                {
                    copied = new Node<int>(pos.GetInfo(), copied);
                }
                pos = pos.GetIN();
                bkCopied = copied;
            }
            return copied;
        }
        public static bool IsExist(Node<int> cop, int x)
        {
            Node<int> pos = cop;
            bool isExist = false;
            while (pos != null && isExist == false)
            {
                if (pos.GetInfo() == x)
                {
                    isExist = true;
                }
                pos = pos.GetIN();
            }
            return isExist;
        }
        public static Node<int> CopyOption2(Node<int> n)
        {
            Node<int> pos = n;
            Node<int> copied = null;
            while (pos != null)
            {
                if (!IsExist(copied, pos.GetInfo()))
                {
                    copied = new Node<int>(pos.GetInfo(), copied);
                }
                pos = pos.GetIN();
            }
            return copied; // not finished
        }
        public static Node<int> Create(Node<int> n) // Mehaber misparim ad minus 9
        {
            Node<int> pos = n;
            Node<int> newL = null;
            Node<int> posNew = null;
            int num = 0;
            while (pos != null)
            {
                if (pos.GetInfo() != -9)
                    num = num * 10 + pos.GetInfo();
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
                        posNew.SetIN(new Node<int>(num));
                        posNew = posNew.GetIN();
                        num = 0;
                    }
                }
                pos = pos.GetIN();
            }
            return newL;
        }

    }
}

