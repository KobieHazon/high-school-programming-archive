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
            double num1, num2;
            double divi;

            Console.WriteLine("enter 2 numbers");

            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            if (num2 != 0) 
              {  
                divi = num1 / num2;
                Console.WriteLine(divi);   
              }
           
             else
            Console.WriteLine("math error");
            
        }
    }
}
