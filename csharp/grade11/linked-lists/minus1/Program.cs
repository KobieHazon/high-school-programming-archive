using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מינוס_1
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
        public static Node<int> WithoutMinus(Node<int> Nums) // . מחזירה אוסף חדש עם מספרים לפני הספרה 1- 
        {
         Node<int> pos=Nums;
         Node<int> New = null;
         int sum = 0;
         Node<int> posnew = null;
             while (pos!=null)
             {
                 if (pos.Getinfo() != -1)
                 {
                     sum += pos.Getinfo();
                     sum = sum * 10;
                 }
                 else
                 {
                     if (New == null)                       // בדיקה בשביל להוסיף לסוף הסדרה
                     {
                         New = new Node<int>(sum / 10, New);
                         
                     }
                     else
                     {
                         posnew = New;
                         while (posnew.GetNext() != null)
                          {
                              posnew = posnew.GetNext();
                          }
                         posnew.SetNext(new Node<int>(sum / 10));
                          
                     }
                 
                     sum = 0;
                 }
               
                 pos = pos.GetNext();
                 if (pos == null)
                 {
                     Node<int> posnew2 = New;
                     while (posnew2.GetNext() != null)
                     {
                         posnew2 = posnew2.GetNext();
                     }
                     posnew2.SetNext(new Node<int>(sum / 10));
                 }
             }
             return New;
        }
        public static bool IsExist(Node<int> Nums,int number) // בודקת אם המספר קיים במערך
        { 
        Node<int>pos=Nums;
            while (pos!=null)
            {
                if (pos.Getinfo() == number)
                {
                    return true;
                }
                pos = pos.GetNext();
            }
            return false;
        }
        public static int CheckPlace(Node<int> Nums, int number) // פעולה שמחזירה את מקום המספר 
        {
            Node<int> pos = Nums;
            int cnt = 1;
            if (IsExist(Nums, number))
            {
                while (pos != null)
                {
                    if (pos.Getinfo() == number)
                    {
                        return cnt;
                    }
                    cnt++;
                    pos = pos.GetNext();
                }
            }
            return -1;
        }
        public static Node<NewHulia> NewList(Node<int>H1,Node<int>H2) // הפעולה שמחזירה חוליה עם מאפייניה
        {
            Node<int> Pos = H1;
            Node<int> Pos2 = H2;
            int Above5 = 0;
            int Position = 0;
            Node<NewHulia> newnumbers=null;
            Node<NewHulia> pos3 = null;
            
            while (Pos != null)
            {
                if (IsExist(Pos2, Pos.Getinfo()))
                {
                    Above5 = sumdigit5(Pos.Getinfo());
                    Position = CheckPlace(Pos2, Pos.Getinfo());
                    if (newnumbers == null) // בדיקה בשביל לשים את הערך החדש בסוף השרשרת
                    {
                        newnumbers = new Node<NewHulia>(new NewHulia(Pos.Getinfo(), Above5, Position), newnumbers);
                        pos3 = newnumbers;
                    }
                    else
                    {
                        while (pos3.GetNext() != null)
                        {
                            pos3 = pos3.GetNext();
                        }
                        pos3.SetNext(new Node<NewHulia>(new NewHulia(Pos.Getinfo(), Above5, Position)));
                    }
                }
        
                Pos = Pos.GetNext();
            }
            return newnumbers;

        }
        public static void Print(Node<int> a) // פעולה שמדפיסה שרשרת מטיפוס מספרים שלמים
        {
            Node<int> pos = a;
            while (pos != null)
            {
                Console.Write(pos.Getinfo() + "");
                if (pos.GetNext() != null)
                {
                    Console.Write(" --> ");
                }
                pos = pos.GetNext();
            }
            Console.WriteLine("");
        }
        public static void Print(Node<NewHulia> a) // פעולה שמדפיסה שרשרת מטיפוס חוליה
        {
            Node<NewHulia> pos = a;
            while (pos != null)
            {
                Console.Write(pos.Getinfo() + "");
                pos = pos.GetNext();
            }
            Console.WriteLine("");
        }
        public static int sumdigit5(int num)
        { 
            int count=0;
            while (num != 0)
            {
                if (num % 10 > 5)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Numbers (the last one must be -1)");
            Console.WriteLine("First Node: "+"\n");
            Node<int> Withminus= maker();
            Console.WriteLine("The first Hulia is :");
            Print(Withminus);
            Node<int> WithOUTminus = WithoutMinus(Withminus);
            Console.WriteLine("With Out the -1 :" );
            Print(WithOUTminus);
           // Print(withminus);
            Console.WriteLine("Enter 10 Numbers :");
            Console.WriteLine("Second Node: ");
            Node<int> Hulia2 = maker();
            Console.WriteLine("The second Hulia is :");
            Print(Hulia2);

            
            Node<NewHulia>newhulia= NewList(WithOUTminus, Hulia2);
            Console.WriteLine("The New list is :");
            Print(newhulia);
  
          
           
            
         
            
        }
    }
}
