using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchProg
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 10: switch (num2)
                    {
                        case 10: Console.WriteLine("The second number is:" + num2);
                            break;
                        case 20: Console.WriteLine("The first number is:" + num1);
                            break;
                        case 30: Console.WriteLine("the numbers sum is:"+ (num1+num2));
                            break;
                }
                    break;
                    
                case 20: 
                switch (num2)
	            {
                    case 10: Console.WriteLine("The numbers sum is:" +(num1+num2));
                        break;
                    case 20: Console.WriteLine("The second number is:" + (num2));
                        break;
                    case 30: Console.WriteLine("The first number is:" + num1);
                        break;
                   
	            }
                break;
                default: Console.WriteLine("The numbers are not suitable");
                break;
                        
                    
            }
        }
    }
}
