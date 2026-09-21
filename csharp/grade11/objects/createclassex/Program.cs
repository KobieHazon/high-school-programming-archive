using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateClassEx
{
    class Program
    {
        public static double action(int Object, string input, string type)
        {
            if (type == null)
            {
                if (Object == 1)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            Box B1 = new Box(5, 18, 8);
            Box B2 = new Box(7, 21, 3);
            Box B3 = new Box(2, 12, 9);

            Console.WriteLine("How do you want to continue? (Set, Get, GetAll)");
            String input = Console.ReadLine();

            if (input == "Set")
            {
                Console.WriteLine("Which Object do you want to set? (1,2,3)");
                int ObjectChoose = int.Parse(Console.ReadLine());
            }
             else if (input == "Get")
            {
                Console.WriteLine("Which Object do you want to Get? (1,2,3)");
                int ObjectChoose = int.Parse(Console.ReadLine());
            }
            else if (input == "GetAll")
            {
                Console.WriteLine("Which Object do you want to GetAll? (1,2,3)");
                int ObjectChoose = int.Parse(Console.ReadLine());
            }
        }
    }
}
