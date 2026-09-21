using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusRoutes_2015___3_
{
    class BusRoutes
    {
        private Node<Station> Route;

        public BusRoutes(Station first, Station second)
        {
            Route = new Node<Station>(second);
            Route = new Node<Station>(first, Route);
        }
        public void SetRoute(Node<Station> Route)
        {
            this.Route = Route;
        }
        public Node<Station> GetRoute()
        {
            return this.Route;
        }

        public Node<Station> IsExistPos(Station S)
        {
            Node<Station> pos = this.GetRoute();
            while (pos != null)
            {
                if (pos.GetInfo().GetX() == S.GetX() && pos.GetInfo().GetY() == S.GetY())
                {
                    return pos;
                }
                pos = pos.GetNext();
            }
            return pos;


        }

        public void AddSLast(Station S)
        {
            Node<Station> pos = IsExistPos(S);
            Node<Station> pos1 = this.GetRoute();
            if (pos == null)
            {
                if (this.Route == null)
                    this.Route = new Node<Station>(new Station(S.GetX(), S.GetY()));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Station>(new Station(S.GetX(), S.GetY())));
                }
            }
        }

        public double RouteLength()
        {
            Node<Station> Pos = this.GetRoute();
            double sum = 0;
            while (Pos.GetNext() != null)
            {
                sum += Pos.GetInfo().distance(Pos.GetNext().GetInfo());
                Pos = Pos.GetNext();
            }
            return sum;
        }
    }
}
