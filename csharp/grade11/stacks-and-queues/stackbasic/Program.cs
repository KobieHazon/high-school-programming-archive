using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackBasic
{
    class Program
    {
        public static int sum(Stack<int> s1)
        {
            Stack<int> pos = new Stack<int>();
            int sum = 0;
            while (!s1.IsEmpty())
            {
                pos.Push(s1.Top());
                sum += s1.Pop();
            }
            while (!pos.IsEmpty())
            {
                s1.Push(pos.Pop());
            }
            return sum;
        }
        public static int Biggest(Stack<int> s1)
        {
            int x = s1.Top();
            while (!s1.IsEmpty())
            {
                if (x < s1.Top())
                {
                    x = s1.Pop();
                }
                else
                {
                    s1.Pop();
                }
            }
            return x;
        }

        public static int size(Stack<int> s)
        {
            if (s.IsEmpty())
            {
                return 0;
            }
            int x = s.Pop();
            int cnt = size(s) + 1;
            s.Push(x);
            return cnt;
        }

        public static Stack<int> CopyQueue(Stack<int> que)// מעתיקה את התור לחדש ושומרת על התור הקיים
        {
            Stack<int> Newque = new Stack<int>();
            Stack<int> pos = new Stack<int>();
            while (!que.IsEmpty())
            {
                Newque.Push(que.Top());
                pos.Push(que.Pop());
            }
            while (!pos.IsEmpty())
            {
                que.Push(pos.Pop());
            }
            Newque.reverse();
            return Newque;
        }

        public static int Sum(Stack<int> S1)
        {
            int sum = 0;
            Stack<int> Spos = S1;
            while (!Spos.IsEmpty())
            {
                 sum += Spos.Pop();
            }
            return sum;
        }

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
        public static int RekursiaTargil10(Stack<int> a) // אורך מחסנית
        {
            if (a.IsEmpty())
            {
                return 0;
            }
            int x = a.Pop();
            int cnt = RekursiaTargil10(a) + 1;
            a.Push(x);
            return cnt;
        }
        public static string Targil11 (Stack<string> a) // כמו TOP
        {
            string x = a.Pop();
            a.Push(x);
            return x;
        }

        public static Stack<int> Targil13(Stack<string> a) // מחסנית חדשה של אורך המחרוזות
        {
            string x;
            Stack<string> pos = new Stack<string>();
            Stack<int> newL = new Stack<int>();
            while (!a.IsEmpty())
            {
                x = a.Pop();
                pos.Push(x);
                newL.Push(x.Length);
            }
            pos.Reverse();
            a = pos;
            return newL;
        }
        public static int GeTopsSum(Stack<int>[] stacks) // סכום ראשי המחסניות
        {
            int sum = 0;
            for (int i = 0; i < stacks.Length; i++)
            {
                if (!stacks[i].IsEmpty())
                {
                    sum += stacks[i].Top();    
                }
            }
            return sum;
        }
        public static bool IsBarackedBalanced(string str) // תקינות סוגריים
        {
            Stack<Char> a = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '(' || str[i] == '[')
                {
                    a.Push(str[i]);
                }
                if (str[i] == '}' || str[i] == ')' || str[i] == ']')
                {
                    if (a.Top() == '(' && str[i] == ')')
                    {
                        a.Pop();
                    }
                    else  if (a.Top() == '[' && str[i] == ']')
                    {
                        a.Pop();
                    }
                    else if (a.Top() == '{' && str[i] == '}')
                    {
                        a.Pop();
                    }
                }
            }
            if (a.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public static void Shtrudel() // הופך אותיות בין שטרודלים אי זוגיים
        {
            string str = " ";
            Stack<char> pos = new Stack<char>();
            Stack<char> pos2 = new Stack<char>();
            char ch = Convert.ToChar(Console.Read());
            bool x = true;
            while (ch != '\r')
            {
                str += ch;
                ch = Convert.ToChar(Console.Read());

            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '@')
                {
                    if (x == true)
                        pos.Push(str[i]);
                    else
                        pos2.Push(str[i]);
                }
                else if (str[i] == '@')
                {
                    x = !x;
                    while (!pos2.IsEmpty())
                    {
                        pos.Push(pos2.Pop());
                    }
                    pos.reverse();
                }
                while (!pos.IsEmpty())
                {
                    Console.Write(pos.Pop());
                }
            }


        }

        public static void ReverseWord20() // My Name is Moshe
        {
            Stack<char> stk = new Stack<char>();

            Console.Write("Type a sentence [Enter to end]: ");

            char ch = Convert.ToChar(Console.Read());
            while (ch != '\r')
            {
                if (ch != ' ')
                    stk.Push(ch);
                else
                {
                    while (!stk.IsEmpty())
                        Console.Write(stk.Pop());
                    Console.Write(" ");
                }
                ch = Convert.ToChar(Console.Read());
            }

            // äãôñú äîéìä äàçøåðä
            while (!stk.IsEmpty())
                Console.Write(stk.Pop());

            Console.WriteLine();
        }

        public static bool IsxZyZx() // תרגיל 21 בספר
        {
            char ch1, ch2;

            //	 éöéøú îçñðéåú òæø ìùîéøú äúåéí äð÷ìèéí
            Stack<char> stk1 = new Stack<char>();
            Stack<char> stk2 = new Stack<char>();

            Console.Write("Type characters sequence [Enter to end]: ");

            ch1 = Convert.ToChar(Console.Read());
            while (ch1 == 'a' || ch1 == 'b' || ch1 == 'c')
            {
                stk1.Push(ch1);
                ch1 = Convert.ToChar(Console.Read());
            }

            if (ch1 != 'Z' || stk1.IsEmpty())
                return false;
            else
            {
                do
                {
                    ch1 = Convert.ToChar(Console.Read());
                    stk2.Push(ch1);
                    ch2 = stk1.Pop();
                    if (ch1 != ch2)
                        return false;
                } while (!stk1.IsEmpty());
            }

            ch1 = Convert.ToChar(Console.Read());
            if (ch1 != 'Z')
                return false;
            else
            {
                do
                {
                    ch1 = Convert.ToChar(Console.Read());
                    ch2 = stk2.Pop();
                    if (ch1 != ch2)
                        return false;
                } while (!stk2.IsEmpty());
            }

            ch1 = Convert.ToChar(Console.Read());
            return ch1 == '\r';
        }

        public static int Bagrut(Stack<int> s1, Stack<int> s2) // לא יודע איזה תרגיל זה
        {

            s1.Pop();
            int sum = s1.Pop() + s1.Pop();
            while (!s2.IsEmpty())
            {
                int n1 = s2.Pop();
                if (!s2.IsEmpty())
                {
                    int n2 = s2.Top();
                    if (sum > n1 + n2)
                    {
                        s2.Pop();
                        if (s2.IsEmpty())
                        {
                            return sum;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

            }
            return sum;
        }
        
        static void Main(string[] args)
        {
          /*  Stack<int> a = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
               a.Push(char.Parse(Console.ReadLine()));
            }
            Console.WriteLine(RekursiaTargil10(a));*/
            //string str = "[2+9] / 6 + (8/2) + {55{}}";
            //bool ffff = IsBarackedBalanced(str);
            //Console.WriteLine(ffff);
            //Shtrudel();

            //Stack<int> S1 = new Stack<int>();
            //Stack<int> S2 = new Stack<int>();
            //S1.Push(307);
            //S1.Push(2);
            //S2.Push(1);
            //S2.Push(4);
            //S2.Push(17);
            //Stack<int>[] Stacks = new Stack<int>[2];
            //Stacks[0] = S1;
            //Stacks[1] = S2;
            //Console.WriteLine(GeTopsSum(Stacks));

            //string str1 = "i am b()re[d right now}";
            //string str2 = "999ssd(scsc) sds[{ }]{ sdsd}";
            //Console.WriteLine(IsBarackedBalanced(str1));
            //Console.WriteLine(IsBarackedBalanced(str2));

            ReverseWord20();
        }
    }
}
