using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus
{
    class Bus
    {
        private int Price;
        private int Line;
        private Node<Station> Stations;

        public Bus(int price, int line)
        {
            this.Price = price;
            this.Line = line;
            this.Stations = null;
        }

        public Bus(Bus B)
        {
            this.Price = B.Price;
            this.Line = B.Line;
            this.Stations = B.Stations;
        }

        public void AddSFirst(Station S)
        {
            this.Stations = new Node<Station>(new Station(S.GetStreet(), S.GetNum()), this.Stations);
        }

        public void AddSLast(Station S)
        {
            Node<Station> pos = IsExistPos(S);
            Node<Station> pos1 = this.Stations;
            if (pos == null)
            {
                if (this.Stations == null)
                    this.Stations = new Node<Station>(new Station(S));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Station>(new Station(S)));
                }
            }
        }

        public int GetPrice()
        {
            return this.Price;
        }
        public int GetLine()
        {
            return this.Line;
        }
        public Node<Station> GetStations()
        {
            return this.Stations;
        }

        public void SetPrice(int price)
        {
            this.Price = price;
        }
        public void SetLine(int line)
        {
            this.Line = line;
        }
        public void SetStations(Node<Station> stations)
        {
            this.Stations = stations;
        }

        public Boolean IsExist(Station S)
        {
            Node<Station> pos = this.GetStations();
            while (pos != null)
            {
                if (S.GetNum() == pos.GetInfo().GetNum() && S.GetStreet() == pos.GetInfo().GetStreet())
                {
                    return true;
                }
                pos = pos.GetNext();
            } return false;
        }

        public Node<Station> IsExistPos(Station S)
        {
            Node<Station> pos = this.GetStations();
            while (pos != null)
            {
                if (pos.GetInfo().GetStreet() == S.GetStreet() && pos.GetInfo().GetNum() == S.GetNum())
                {
                    return pos;
                }
                    pos = pos.GetNext();
            }
            return pos;


        }

        public int Navigation(Station Start, Station End)
        {
            Node<Station> Pos = this.IsExistPos(Start);
            int cnt = 0;

            if (Pos != null && this.IsExist(End) == true)
            {
                while ((Pos.GetInfo().GetNum() != End.GetNum() && Pos.GetInfo().GetStreet() != End.GetStreet()) && Pos != null)
                {
                    cnt = cnt + 1;
                    Pos = Pos.GetNext();
                }
                return (cnt * this.GetPrice());
            }
            else
            {
                return -1;
            }
        }
    }
}
