using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Rectangle
    {
        private Point BottomLeft;
        private Point TopRight;

        public Rectangle(Point BottomLeft, Point TopRight)
        {
            this.BottomLeft = BottomLeft;
            this.TopRight = TopRight;
        }

        public Rectangle(Point BottomLeft, double width, double height)
        {
            this.BottomLeft = BottomLeft;
            Point temp = new Point((this.BottomLeft.GetX() + width), (this.BottomLeft.GetY() + height));
            this.TopRight = temp;
        }

        public double GetArea()
        {
            return ((this.TopRight.GetX() - this.BottomLeft.GetX()) * (this.TopRight.GetY() - this.BottomLeft.GetY()));
        }

        public double GetPerimeter()
        {
            return ((2 * (this.TopRight.GetX() - this.BottomLeft.GetX())) + (2 * (this.TopRight.GetY() - this.BottomLeft.GetY())));
        }

        public void Move(double DeltaX, double DeltaY)
        {
            this.BottomLeft.SetX(this.BottomLeft.GetX() + DeltaX);
            this.BottomLeft.SetY(this.BottomLeft.GetY() + DeltaY);
            this.TopRight.SetX(this.TopRight.GetX() + DeltaX);
            this.TopRight.SetY(this.TopRight.GetY() + DeltaY);
        }

        public override string ToString()
        {
            return ("Rectangle: \n\nbottom-left point: " + this.BottomLeft.ToString() + "\ntop-right point: " + this.TopRight.ToString());
        }
    }
}
