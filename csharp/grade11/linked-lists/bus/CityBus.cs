using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus
{
    class CityBus
    {
        private string City;
        private Node<Bus> BLines;

        public CityBus(string city)
        {
            this.City = city;
            this.BLines = null;
        }

        public void AddBFirst(Bus B)
        {
            this.BLines = new Node<Bus>(new Bus(B), this.BLines);
        }

        public Node<Bus> IsExistPos(Bus B)
        {
            Node<Bus> pos = this.GetBLines();
            while (pos != null)
            {
                if (pos.GetInfo().GetLine() == B.GetLine() && pos.GetInfo().GetPrice() == B.GetPrice() && pos.GetInfo().GetStations() == B.GetStations())
                {
                    return pos;
                }
                    pos = pos.GetNext();
            }
            return pos;


        }
        public void AddBLast(Bus B)
        {
            Node<Bus> pos = this.IsExistPos(B);
            Node<Bus> pos1 = this.GetBLines();
            if (pos == null)
            {
                if (this.GetBLines() == null)
                    this.BLines = new Node<Bus>(new Bus(B));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Bus>(new Bus(B)));
                }
            }
            
        }
        public string GetCity()
        {
            return this.City;
        }
        public Node<Bus> GetBLines()
        {
            return this.BLines;
        }

        

    }
}
