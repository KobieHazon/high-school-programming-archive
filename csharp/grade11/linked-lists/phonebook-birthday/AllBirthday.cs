using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AllBirthday
    {
        private Node<Birthday>[] bDayList;

        public AllBirthday()
        {
            this.bDayList = null;
        }
        public Node<Birthday>[] GetBDayList()
        {
            return this.bDayList;
        }
        public bool IsExist(Birthday b, int m)
        {
            Node<Birthday> pos = this.bDayList[m];
            while (pos != null)
            {
                if (pos.GetInfo().GetName() == b.GetName())
                    return true;
                pos = pos.GetNext();
            }
            return false;
        }
        public void AddFirstBday(Birthday b, int m)
        {
            if (IsExist(b, m))
                this.bDayList[m] = new Node<Birthday>(new Birthday(b), this.bDayList[m]);
        }
        public int GetHowManyBdaysInMonth(int month)
        {
            Node<Birthday> pos = this.bDayList[month];
            int counter = 0;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            return counter;
        }
        public void RemoveBDay(Birthday b, int m)
        {
            if (IsExist(b, m))
            {
                Node<Birthday> pos = this.bDayList[m];
                Node<Birthday> pos1 = this.bDayList[m].GetNext();
                if (pos.GetInfo().GetName() == b.GetName())
                {
                    this.bDayList[m] = this.bDayList[m].GetNext();
                }
                else
                {
                    while (pos1 != null)
                    {
                        if (pos1.GetInfo().GetName() == b.GetName())
                        {
                            Node<Birthday> temp = pos1.GetNext();
                            pos1.SetNext(null);
                            pos.SetNext(temp);
                        }
                        pos1 = pos1.GetNext();
                        pos = pos.GetNext();
                    }
                }
            }
        }
        public int MostBDays()
        {
            int biggest = GetHowManyBdaysInMonth(0);
            int place = 0;
            for (int i = 0; i < 12; i++)
            {
                if (biggest < GetHowManyBdaysInMonth(i))
                {
                    biggest = GetHowManyBdaysInMonth(i);
                    place = i;
                }
            }
            return place;
        }
        public bool IsExist2(Birthday b, int m)
        {
            Node<Birthday> pos = this.bDayList[m];
            int counter = 0;
            while (pos != null)
            {
                if (pos.GetInfo().GetName() == b.GetName())
                    counter++;
                pos = pos.GetNext();
            }
            if (counter > 1)
                return true;
            return false;
        }
        public void SinunNames(int month)
        {
            Node<Birthday> pos = this.bDayList[month];
            while (pos != null)
            {
                if (IsExist2(pos.GetInfo(), month))
                {
                    
                }
            }
        }
    }
}
