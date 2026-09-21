using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static Node<int> Minus1(Node<int> a)
        {
            Node<int> pos = a;
            int num = 0;
            Node<int> newList = null;
            Node<int> posNew = null;
            while (pos != null)
            {
                if (pos.GetInfo() != -1)
                {
                    num += pos.GetInfo();
                    num *= 10;
                }
                else
                {
                    if (newList == null)
                    {
                        newList = new Node<int>((num / 10));
                        posNew = newList;
                    }
                    else
                    {
                        posNew.SetNext(new Node<int>(num / 10));
                        posNew = posNew.GetNext();
                    }
                    num = 0;
                }
                pos = pos.GetNext();
            }
            return newList;
        }
        public static int BiggetDigits5(int num)
        {
            int cnt = 0;
            while (num != 0)
            {
                if (num % 10 > 5)
                {
                    cnt++;
                }
                num /= 10;
            }
            return cnt;
        }
        public static Node<Prop> NewList(Node<int> a, Node<int> b)
        {
            Node<int> pos = Minus1(a);
            Node<int> pos2 = b;
            Node<Prop> newList = null;
            while (pos != null)
            {
                if (IsExist(pos2, pos.GetInfo()) != -1)
                {
                    newList = new Node<Prop>(new Prop(pos.GetInfo(), IsExist(pos2, pos.GetInfo()), BiggetDigits5(pos.GetInfo())), newList);
                }
                pos = pos.GetNext();
            }
            return newList;
        }
        public static int IsExist(Node<int> a, int num)
        {
            int cnt = 0;
            Node<int> pos = a;

            while (pos != null)
            {
                cnt++;
                if (pos.GetInfo() == num)
                {
                    return cnt;
                }
                pos = pos.GetNext();
            }
            return -1;
        }
        public static Node<int> maker()
        {
            Node<int> a = null;
            Node<int> pos = null;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Num: ");
                int x = int.Parse(Console.ReadLine());
                if (a == null)
                {
                    a = new Node<int>(x, a);
                    pos = a;
                }
                else
                {
                    pos.SetNext(new Node<int>(x));
                    pos = pos.GetNext();
                }
            }
            return a;
        }
        public static void print(Node<int> a)
        {
            Node<int> pos = a;
            while (pos!= null)
            {
                Console.Write(pos.GetInfo() + "    ");
                pos = pos.GetNext();
            }
        }
        public static Node<Prop> NewList2(Node<int> a, Node<int> b)
        {
            Node<int> pos = a;
            Node<int> pos2 = b;
            Node<Prop> newList = null;
            int place = 1;
            int num = 0;
            int biggerThan = 0;
            while (pos != null)
            {
                if (pos.GetInfo() != -1)
                {
                    if (pos.GetInfo() > 5)
                        biggerThan++;
                    num = num * 10 + pos.GetInfo();
                }
                else
                {
                    while (pos2 != null)
                    {
                        if (num == pos2.GetInfo())
                        {
                            newList = new Node<Prop>(new Prop(num, place, biggerThan), newList);
                        }
                        place++;
                        pos2 = pos2.GetNext();
                    }
                    pos2 = b;
                    num = 0;
                    place = 1;
                }
                pos = pos.GetNext();
                if (pos == null) // checking if -1 not at the end
                {
                    while (pos2 != null)
                    {
                        if (num == pos2.GetInfo())
                        {
                            newList = new Node<Prop>(new Prop(num, place, biggerThan), newList);
                        }
                        place++;
                        pos2 = pos2.GetNext();
                    }
                }
            }
            return newList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WithMinus1");
            Node<int> withMinus = maker();
            Console.WriteLine("With Positive");
            Node<int> positive = maker();
            Console.WriteLine("With Minus ------------>\n");
            print(withMinus);
            Console.WriteLine("With Positiveeeeeeeeee\n\n");
            print(positive);
            Node<int> withOutMin = Minus1(withMinus);
            Console.WriteLine("\n\nWithout -");
            print(withOutMin);

            Node<Prop> newL = NewList(withMinus, positive);

            Console.WriteLine("   \n\n\n");
            Node<Prop> possss = NewList2(withMinus, positive);
            while (possss != null)
            {
                Console.WriteLine(possss.GetInfo().ToString() + "\n\n");
                possss = possss.GetNext();
            }

            


        }
    }
}
