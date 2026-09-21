using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Train
    {
        private Engine Angie;
        private Carriage[] Carr;
        private const int CarNumber = 5;
        private int lastPos;

        public Train(Engine e)
        {
            Angie = e;
            Carr = new Carriage[CarNumber];
            lastPos = 0;
        }
        public Engine GetEngine()
        {
            return this.Angie;
        }
        public Carriage[] GetCarr()
        {
            return this.Carr;
        }
        public int GetLastPos()
        {
            return this.lastPos;
        }
        public void SetEngine(Engine e)
        {
            this.Angie = e;
        }
        public void SetCarr(Carriage[] Carr)
        {
            this.Carr = Carr;
        }
        public void SetLastPos(int lastPos)
        {
            this.lastPos = lastPos;
        }
        public void Add(Carriage c)
        {
            if (lastPos != Carr.Length)
            {
                Carr[lastPos] = c;
                this.lastPos++;
            }

        }
        public void Remove(int place)
        {
            for (int i = place; i < lastPos-1; i++)
            {
                Carr[i] = Carr[i + 1];
            }
            Carr[lastPos-1] = null;
            lastPos--;
        }
        public override string ToString()
        {
            int Alltravelers = 0;
            for (int i = 0; i < lastPos; i++)
            {
                Alltravelers += this.Carr[i].GetTravelers();
            }
            return ("My Train" + "\nEngine details -  \n" + this.Angie.ToString() + "\nThe number of travelers on the train - " + Alltravelers);
        }
    }
}
