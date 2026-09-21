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
            Student[] arr = new Student[5];
            arr[0] = new Student("Itay Ben Shmoal", 98, 95);
            arr[1] = new Student("Ohad Ben Shmoal", 98, 100);
            arr[2] = new Student("Raz Barda", 100, 100);
            arr[3] = new Student("Shahar Band", 99, 97);
            arr[4] = new Student("Kobi King", 101, 110);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
                Console.WriteLine("Average - " + arr[i].StudentAverage());
                Console.WriteLine("____________________________________");
            }

            int biggestarr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].StudentAverage() > arr[biggestarr].StudentAverage())
                {
                    biggestarr = i;
                }
            }

            Console.WriteLine("The student with the biggest average is - " + arr[biggestarr].GetName() + "\nHis average is - " + arr[biggestarr].StudentAverage());


        }
    }
}
