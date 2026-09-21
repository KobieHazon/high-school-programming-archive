using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Triangle
    {
        private Point P1, P2, P3;

        public Triangle(Point P1, Point P2, Point P3)
        {
            this.P1 = P1;
            this.P2 = P2;
            this.P3 = P3;
        }

        public Point GetP1()
        {
            return this.P1;
        }
        public Point GetP2()
        {
            return this.P2;
        }
        public Point GetP3()
        {
            return this.P3;
        }

        public void SetP1(Point p1)
        {
            this.P1 = p1;
        }
        public void SetP2(Point p2)
        {
            this.P2 = p2;
        }
        public void SetP3(Point p3)
        {
            this.P3 = p3;
        }

        public override string ToString()
        {
            return ("The 3 Points are: " + this.P1.ToString() + "," + this.P2.ToString() + "," + this.P3.ToString());
        }

        public bool IsTriangle()
        {
            double a = P1.distance(P2);
            double b = P2.distance(P3);
            double c = P3.distance(P1);
            if ((a + b) > c && (a + c) > b && (b + c) > a)
                return true;
            else
                return false;
        }
        public double P()
        {
            if (this.IsTriangle() == true)
                return (P1.distance(P2) + P2.distance(P3) + P1.distance(P3));
            else
                return -1;
        }

        public double S()
        {
            double a = P1.distance(P2);
            double b = P2.distance(P3);
            double c = P3.distance(P1);
            if (P1.Gradient(P2) * P2.Gradient(P3) == -1)
            {
                return ((a * b) / 2);
            }
            else if (P2.Gradient(P3) * P3.Gradient(P1) == -1)
                return ((b * c) / 2);
            else if (P1.Gradient(P2) * P3.Gradient(P1) == -1)
                return ((a * c) / 2);
            else
                return -1;
        }



        //פעלוה בונה, בודקת אפ אפשר ליצור משולש אם כן מחשב היקף, עולה שבודקת אם זה ישר זווית אם כן אז את השטח
    }
}
