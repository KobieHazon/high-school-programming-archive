using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OriBachar_Node3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList studlist = new StudentList();

            for (int i = 0; i < 4; i++)
            {

                int age = int.Parse(Console.ReadLine());

                string name = Console.ReadLine();

                Student stu = new Student(name, age);

                studlist.Add(stu);
            }

            studlist.ToString();

            Console.WriteLine(studlist);

        }
    }
}
