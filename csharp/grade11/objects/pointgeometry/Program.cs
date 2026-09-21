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
            Point P1 = new Point(5, 6);
            Point P2 = new Point(3, 9);
            Point P3 = new Point(7, 5.5);
            Circle C1 = new Circle(P1, 12);
            Triangle T1 = new Triangle(P1, P2, P3);

            Console.WriteLine("Lets do a few things with our Points: " + P1.ToString() + " , " + P2.ToString() + " , " + P3.ToString());
            Console.WriteLine("Lets start by using the Points for a circle: \n" + C1.ToString());
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("\nLets change a bit");
            C1.SetCenter(P2);
            C1.SetRadius(7);
            Console.WriteLine("\nThe Center point is - " + C1.GetCenter() + "\nThe Radius is - " + C1.GetRadius());
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("The scope of the new circle is - " + C1.Scope());
            Console.WriteLine("The Area of the new circle is - " + C1.area());

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Lets start using the triangle we can create using the 3 Points: \n\nIs it a valid traingle?");
            if (T1.IsTriangle() == true)
                Console.WriteLine("Houston we have a Triangle");
            else
                Console.WriteLine("Is is not a valid triangle :(\n\n");

            Console.WriteLine("The P(heikef) of this Triangle is: " + T1.P());

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Lets check if this triangle has a 90 degrees angle ");
            if (T1.S() == -1)
            {
                Console.WriteLine("It doesnt have a 90 degrees. Lets change it!");
                P1.SetX(8);
                P1.SetY(9);
                P2.SetY(1);
                P2.SetX(12);
                P3.SetX(0);
                P3.SetY(-5);

                Console.WriteLine("Does it have a 90 degrees now? ");
                if (T1.S() != -1)
                {
                    Console.WriteLine("The triangle has a 90 degrees!");
                    Console.WriteLine("The area of the new triangle is - " + T1.S());
                }
                else
                    Console.WriteLine("The triangle doesnt have a 90 degrees :(");
                Console.WriteLine("\n");
            }
            else
                Console.WriteLine("It has a 90 degrees and its area is - " + T1.S());

            Console.WriteLine("---------------------------------------------------");
            

            Console.WriteLine("The Points of the new triangle are: \n" + T1.ToString() );
            Console.WriteLine("---------------------------------------------------");

            Rectangle R1 = new Rectangle(P1, P3);
            Console.WriteLine(R1.ToString());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("The area is - " + R1.GetArea());
            Console.WriteLine("The  Perimeter - " + R1.GetPerimeter());
            Console.WriteLine("what would you like to add to the x and y?");
            double tempX = double.Parse(Console.ReadLine());
            double tempY = double.Parse(Console.ReadLine());
            R1.Move(tempX, tempY);
            Console.WriteLine(R1.ToString());


        }
    }
}
