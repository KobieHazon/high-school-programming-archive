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

        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }

        public void SetX(double X)
        {
            this.x = X;
        }
        public void SetY(double Y)
        {
            this.y = Y;
        }

        public override string ToString()
        {
            return ("(" + this.x + "," + this.y + ")");
        }

        public Point Middle(Point P2)
        {
            double MiddleX = (this.x + P2.GetX()) / 2;
            double MiddleY = (this.y + P2.GetY()) / 2;
            return new Point(MiddleX, MiddleY);
        }

        public double distance(Point P2)
        {
            return (Math.Sqrt(Math.Pow(this.x - P2.GetX(), 2) + (Math.Pow(this.y - P2.GetY(), 2)))); 
        }

        public double Gradient(Point P2)
        {
            return ((this.y - P2.GetY()) / (this.x - P2.GetX()));
        }
    }
}
