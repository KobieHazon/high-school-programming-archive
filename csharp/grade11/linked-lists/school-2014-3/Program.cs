using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_2014___3_
{
    class Program
    {
        public static Node<Student>[] Months(School S)
        {
            Node<Student> pos = null;
            Node<Student>[] Months = new Node<Student>[12];
            int month = -1;
            for (int i = 0; i < S.GetStu().Length; i++)
            {
                pos = S.GetStu()[i];
                while (pos != null)
                {
                    month = pos.GetInfo().GetBDay().GetMonth() - 1;
                    Months[month] = new Node<Student>(pos.GetInfo(), Months[month]);
                    pos = pos.GetNext();
                }
            }
            return Months;
        }


        static void Main(string[] args)
        {
            Student S1 = new Student("Student 01", new Birth(1, 1, 2000));
            Student S2 = new Student("Student 02", new Birth(2, 1, 2000));
            Student S3 = new Student("Student 03", new Birth(3, 1, 2000));
            Student S4 = new Student("Student 04", new Birth(4, 1, 2000));
            Student S5 = new Student("Student 05", new Birth(5, 1, 2000));
            Student S6 = new Student("Student 06", new Birth(6, 1, 2000));
            Student S7 = new Student("Student 07", new Birth(7, 1, 2000));
            Student S8 = new Student("Student 08", new Birth(8, 1, 2000));
            Student S9 = new Student("Student 09", new Birth(9, 1, 2000));
            Student S10 = new Student("Student 10", new Birth(10, 1, 2000));

            School SC1 = new School();
            SC1.AddSFirst(S1, 0);
            SC1.AddSFirst(S2, 1);
            SC1.AddSFirst(S3, 2);
            SC1.AddSFirst(S4, 3);
            SC1.AddSFirst(S5, 4);
            SC1.AddSFirst(S6, 5);
            SC1.AddSFirst(S7, 0);
            SC1.AddSFirst(S8, 1);
            SC1.AddSFirst(S9, 2);
            SC1.AddSFirst(S10, 3);

            Node<Student>[] temp = Months(SC1);
            Node<Student> pos = null;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("Month " + i);
                pos = temp[i];
                while (pos != null)
                {
                    Console.WriteLine(pos.GetInfo().GetName());
                    pos = pos.GetNext();
                }
            }



        }
    }
}
