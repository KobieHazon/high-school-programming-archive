using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetPoint(double xinput, double yinput)
        {
            x = xinput;
            y = yinput;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public string RePoint()
        {
            return "X = " + this.x + " Y = " + this.y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Point p1 = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
            Point p2 = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));

            
            Console.WriteLine(p1.RePoint());
            Console.WriteLine(p2.RePoint());

            Point avg = new Point((p1.GetX()+p2.GetX())/2, (p1.GetY() + p2.GetY())/2);
            Console.WriteLine(avg.RePoint());

        }
    }
}
