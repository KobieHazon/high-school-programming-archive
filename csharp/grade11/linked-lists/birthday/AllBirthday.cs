using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AllBirthday
    {
        private Node<Birthday>[] BDayList;

        public AllBirthday()
        {
            this.BDayList = new Node<Birthday>[12];
        }
        public Node<Birthday>[] GetBDayList()
        {
            return this.BDayList;
        }
        public bool IsExist(Birthday b, int m)
        {
            Node<Birthday> pos = this.BDayList[m];
            while (pos != null)
            {
                if (pos.GetInfo().GetName() == b.GetName())
                    return true;
                pos = pos.GetNext();
            }
            return false;
        }

        //public bool IsExistCNT(Birthday b, int m)
        //{
        //    Node<Birthday> pos = this.BDayList[m];
        //    int counter = 0;
        //    while (pos != null)
        //    {
        //        if (pos.GetInfo().GetName() == b.GetName())
        //            counter++;
        //        pos = pos.GetNext();
        //    }
        //    if (counter > 1)
        //        return true;
        //    return false;
        //}

        public int BDaysinMonth(int month)
        {
            Node<Birthday> pos = this.BDayList[month];
            int counter = 0;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            return counter;
        }

        public void AddBDayLast(Birthday b, int M)
        {
            if (IsExist(b, M) == false)
                this.BDayList[M] = new Node<Birthday>(new Birthday(b), this.BDayList[M]);
        }
        
        public void RemoveBDay(Birthday b, int m)
        {
            if (IsExist(b, m))
            {
                Node<Birthday> pos = this.BDayList[m];
                Node<Birthday> pos1 = this.BDayList[m].GetNext();
                if (pos.GetInfo().GetName() == b.GetName())
                {
                    this.BDayList[m] = this.BDayList[m].GetNext();
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
            int biggest = BDaysinMonth(0);
            int place = 0;
            for (int i = 0; i < 12; i++)
            {
                if (biggest < BDaysinMonth(i))
                {
                    biggest = BDaysinMonth(i);
                    place = i;
                }
            }
            return place;
        }
        
        public void SinunNames(int month)
        {
            Node<Birthday> pos = this.BDayList[month];
            while (pos != null)
            {
                if (IsExistCNT(pos.GetInfo(), month))
                {
                    
                }
            }
        }
    }
}
