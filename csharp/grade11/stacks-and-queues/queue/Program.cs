using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static Queue<int> maker() //בונה תור שמכיל 6 חוליות
        {
            int x;
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 6; i++)
            {
               x = int.Parse(Console.ReadLine());
               que.Insert(x);
            }
            return que;
        }
        public static int biggestnum(Queue<int> que)// מחזירה את המספר הגדול ביותר בתור
        {
            Queue<int> pos = new Queue<int>();
            int i = que.Head();
            while (!que.IsEmpty())
            {
                if (i < que.Head())
                {
                    i = que.Head();
                }
                pos.Insert(que.Remove());
            }
            while (!pos.IsEmpty())
            {
                que.Insert(pos.Remove());
            }
            return i;
        }

        public static int biggestnumDeleting(Queue<int> que)// מחזירה את המספר הגדול ביותר בתור
        {
            Queue<int> pos = new Queue<int>();
            int max = que.Head();
            while (!que.IsEmpty())
            {
                if (max < que.Head())
                {
                    pos.Insert(max);
                    max = que.Remove();
                }
                else
                {
                    pos.Insert(que.Remove());
                }
            }
            while (!pos.IsEmpty())
            {
                que.Insert(pos.Remove());
            }
            return max;
        }

        public static Queue<int> CopyQueue(Queue<int> que)// מעתיקה את התור לחדש ושומרת על התור הקיים
        {
            Queue<int> Newque = new Queue<int>();
            Queue<int> pos = new Queue<int>();
            while (!que.IsEmpty())
            {
                Newque.Insert(que.Head());
                pos.Insert(que.Remove());
            }
            while (!pos.IsEmpty())
            {
                que.Insert(pos.Remove());
            }
            return Newque;
        }
        public static int sumque(Queue<int>que)// מחזירה סכום של כל איברי התור
        {
            Queue<int> pos = new Queue<int>();
            int sum=0;
            while (!que.IsEmpty())
            {
                sum += que.Head();
                pos.Insert(que.Remove());
            }
            while (!pos.IsEmpty())
            {
                que.Insert(pos.Remove());
            }
            return sum;
        }
        public static bool IsExist(Queue<int> que,int a)// בדיקה האם המספר A קיים בתור
        {
            Queue<int> pos = CopyQueue(que);
            if (pos.IsEmpty())
            {
                return false;
            }
            while (!pos.IsEmpty())
            {
                if (a == pos.Head())
                {
                    return true;
                }
                pos.Remove();
            }
            return false;
        }
        public static Queue<int> CommonNums(Queue<int> que1, Queue<int> que2)// מחזירה תור חדש המכיל את המספרים המשותפים שהופיעו גם בתור 1 וגם בתור 2 בלי כפילויות
        {
            Queue<int> NewQue = new Queue<int>();
            Queue<int> pos1 =CopyQueue(que1);
            Queue<int> pos2 =CopyQueue(que2);
            while (!pos1.IsEmpty())
            {
                while (!pos2.IsEmpty())
                {
                    if (pos1.Head() == pos2.Head() && IsExist(NewQue, pos1.Head()) == false)
                    {
                        NewQue.Insert(pos1.Head());        
                    }
                    pos2.Remove();
                 }
                pos1.Remove();
                pos2 = CopyQueue(que2);
            }
           
            return NewQue;
        }
        public static int Count(Queue<int> Q)
        {
            int cnt = 0;
            Queue<int> pos = CopyQueue(Q);
            while (!pos.IsEmpty())
            {
                cnt++;
                pos.Remove();
            }
            return cnt;
        }
        public static void Removenum(Queue<int> Q,int num) 
        {
           
            Queue<int> NewQue = new Queue<int>();
            while (!Q.IsEmpty())
            {
                if (Q.Head() == num)
                {
                    Q.Remove();
                }
                else
                    NewQue.Insert(Q.Remove());
            }
            while (!NewQue.IsEmpty())
            {
                Q.Insert(NewQue.Remove());
            }
          
        }
        public static Queue<int> BiggestHalf(Queue<int> Q1)
        {
            Queue<int> NewQue = new Queue<int>();
            Queue<int> pos = CopyQueue(Q1);
            for (int i = 0; i < (Count(Q1))/2; i++)
            {
                NewQue.Insert(biggestnum(pos));
                Removenum(pos,biggestnum(pos));
               
            }
            NewQue.Reverse();
            return NewQue;

        }
        public static int counttimes(Queue<int> Q,int a)
        {
            Queue<int> pos = CopyQueue(Q);
            int cnt=0;
            while (!pos.IsEmpty())
            {
                if (pos.Head() == a)
                {
                    cnt++;
                }
                pos.Remove();
            }
            return cnt;
        }
        public static void Removenumeveryappearence(Queue<int> Q, int num) 
        {

            Queue<int> NewQue = new Queue<int>();
            while (!Q.IsEmpty())
            {
                if (Q.Head() == num)
                {
                    Q.Remove();
                }
                else
                    NewQue.Insert(Q.Remove());
            }
            while (!NewQue.IsEmpty())
            {
                Q.Insert(NewQue.Remove());
            }

        }
        public static Queue<CommonNum> Howcommon(Queue<int> Q)
        {
            Queue<int> pos = CopyQueue(Q);
            Queue<CommonNum> NewQueue=new Queue<CommonNum>();
            while (!pos.IsEmpty())
            {
                NewQueue.Insert(new CommonNum(pos.Head(),counttimes(pos,pos.Head())));
                Removenumeveryappearence(pos, pos.Head());
            }
            return NewQueue;
        }
        static void Main(string[] args)
        {
            Queue<int> Q1 = maker();
            Console.WriteLine(Q1);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Queue<CommonNum> QN = Howcommon(Q1);
            Console.WriteLine(QN);

 
        }
    }
}
