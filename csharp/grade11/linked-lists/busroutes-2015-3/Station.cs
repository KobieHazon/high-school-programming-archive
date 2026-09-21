using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusRoutes_2015___3_
{
    class Station
    {
        private double x;
        private double y;

        public Station(double x, double y)
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

        public Station Middle(Station P2)
        {
            double MiddleX = (this.x + P2.GetX()) / 2;
            double MiddleY = (this.y + P2.GetY()) / 2;
            return new Station(MiddleX, MiddleY);
        }

        public double distance(Station P2)
        {
            return (Math.Sqrt(Math.Pow(this.x - P2.GetX(), 2) + (Math.Pow(this.y - P2.GetY(), 2))));
        }

        public double Gradient(Station P2)
        {
            return ((this.y - P2.GetY()) / (this.x - P2.GetX()));
        }
    }
}
