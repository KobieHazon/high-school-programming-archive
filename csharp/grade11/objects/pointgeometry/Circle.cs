using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circle
    {
        private Point Center;
        private double Radius;

        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Point GetCenter()
        {
            return this.Center;
        }
        public double GetRadius()
        {
            return this.Radius;
        }

        public void SetCenter(Point Center)
        {
            this.Center = Center;
        }
        public void SetRadius(double Radius)
        {
            this.Radius = Radius;
        }

        public override string ToString()
        {
            return (" The Center is: " + this.Center.ToString() + ", The Radius is: " + this.Radius);
        }

        public double Scope()
        {
            return (2 * Math.PI * this.Radius);
        }
        public double area()
        {
            return (this.Radius * this.Radius * Math.PI);
        }



    }
}
