using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateClassEx
{
    class Box
    {
        private double Width;
        private double Length;
        private double High;

        public Box(double Width, double Length, double High)
        {
            this.Width = Width;
            this.Length = Length;
            this.High = High;
        }

        public double GetWidth()
        {
            return this.Width;
        }
        public double GetLength()
        {
            return this.Length;
        }
        public double GetHigh()
        {
            return this.High;
        }

        public void SetWidth(double Width)
        {
            this.Width = Width;
        }
        public void SetLength(double Length)
        {
            this.Length = Length;
        }
        public void SetHigh(double High)
        {
            this.High = High;
        }

        public override string ToString()
        {
            return (this.Width + " " + this.Length + " " + this.High);
        }
    }
}
