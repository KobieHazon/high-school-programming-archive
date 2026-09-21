using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bucket
    {
        private int Capacity;
        private double CurrentAmount;

        public Bucket(int Capacity)
        {
            this.Capacity = Capacity;
            this.CurrentAmount = 0;
        }

        public void Empty()
        {
            this.CurrentAmount = 0;
        }
        public bool IsEmpty()
        {
            return (this.CurrentAmount == 0);
        }
        public void Fill(double AmountToFill)
        {
            if ((this.CurrentAmount + AmountToFill) < this.Capacity)
            {
                this.CurrentAmount += AmountToFill;
            }
            else
            {
                this.CurrentAmount = this.Capacity;
            }
        }

        public int GetCapacity()
        {
            return this.Capacity;
        }
        public double GetCurrentAmount()
        {
            return this.CurrentAmount;
        }

        public void PourInto(Bucket BucketInto)
        {
            if ((this.CurrentAmount + BucketInto.GetCurrentAmount()) < BucketInto.GetCapacity())
            {
                BucketInto.Fill(this.CurrentAmount);
                this.Empty();
                
            }
            else
            {
                BucketInto.Fill(BucketInto.GetCapacity());
                this.Empty();
            }
        }

        public override string ToString()
        {
            return (this.Capacity + " " + this.CurrentAmount);
        }
    }
}
