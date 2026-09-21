using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipInfo
{
    class Program
    {

        public static Node<Char> MakerStart()
        {
            Node<Char> L1 = null;
            Node<Char> pos = null;
            for (int i = 0; i < 20; i++)
            {
                char x = char.Parse(Console.ReadLine());
                if (L1 == null)
                {
                    L1 = new Node<Char>(x);
                    pos = L1;
                }
                else
                {
                    pos.SetNext(new Node<Char>(x));
                    pos = pos.GetNext();
                }
            }
            return L1;
        }

        public static void Print(Node<Char> L)
        {
            Node<Char> pos = L;

            Console.Write(pos.GetInfo().ToString());
            pos = pos.GetNext();
            while (pos != null)
            {
                Console.Write(" -> " + pos + "");
                pos = pos.GetNext();
            }
        }

        public static void Print(Node<ZipInfo> L)
        {
            Node<ZipInfo> pos = L;

            Console.Write(pos.GetInfo().ToString());
            pos = pos.GetNext();
            while (pos != null)
            {
                Console.Write(" -> " + pos + "");
                pos = pos.GetNext();
            }
        }

        public static Node<ZipInfo> Zip(Node<char> L)
        {
            Node<char> pos = L;
            Node<ZipInfo> Zip = null;
            Node<ZipInfo> ZipPos = null;
            long counter = 0;

            while (pos.GetNext() != null)
            {
                
                    if (pos.GetInfo() == pos.GetNext().GetInfo())
                        counter++;
                    else
                    {
                        if (Zip == null)
                        {
                            Zip = new Node<ZipInfo>(new ZipInfo(pos.GetInfo(), counter + 1));
                            ZipPos = Zip;
                        }
                        else
                        {
                            ZipPos.SetNext(new Node<ZipInfo>(new ZipInfo(pos.GetInfo(), counter + 1)));
                            ZipPos = ZipPos.GetNext();
                        }
                        counter = 0;
                    }
                
                pos = pos.GetNext();
            }

                ZipPos.SetNext(new Node<ZipInfo>(new ZipInfo(pos.GetInfo(), counter + 1)));
                ZipPos = ZipPos.GetNext();

            return Zip;
        }

        public static Node<Char> UnZip(Node<ZipInfo> L)
        {
            Node<ZipInfo> pos = L;
            Node<Char> UnZip = null;
            Node<Char> UnZipPos = null;
            long counter = 0;

            while (pos != null)
            {

                counter = pos.GetInfo().GetTimes();
                for (long i = counter; i > 0; i--)
                {
                        if (UnZip == null)
                        {
                            UnZip = new Node<Char>(pos.GetInfo().GetCh());
                            UnZipPos = UnZip;
                        }
                        else
                        {
                            UnZipPos.SetNext(new Node<char>(pos.GetInfo().GetCh()));
                            UnZipPos = UnZipPos.GetNext();
                        }
                }
                pos = pos.GetNext();
                counter = 0;


            }
            return UnZip;
        }
        static void Main(string[] args)
        {
            Node<Char> L = MakerStart();
            Console.WriteLine();
            Print(L);
            
            Console.WriteLine("-------------------------------------");

            Node<ZipInfo> Z = Zip(L);
            Print(Z);
            Console.WriteLine();
            Node<Char> UN = UnZip(Z);
            Print(UN);
            Console.WriteLine();
        }
    }
}
