using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hishtalmoot
{
    class Course
    {
        private string Code;
        private string Name;
        private string Date;
        private int Hours;
        private int MaxParts;
        private Node<Participent> Participents;

        public Course(string code, string name, string date, int hours, int maxparts)
        {
            this.Code = code;
            this.Name = name;
            this.Date = date;
            this.Hours = hours;
            this.MaxParts = maxparts;
            Participents = null;
        }
        public Course(Course C)
        {
            this.Code = C.GetCode();
            this.Name = C.GetName();
            this.Date = C.GetDate();
            this.Hours = C.GetHours();
            this.MaxParts = C.GetMaxParts();
            Participents = null;
        }
        public string GetCode()
        {
            return this.Code;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetDate()
        {
            return this.Date;
        }
        public int GetHours()
        {
            return this.Hours;
        }
        public int GetMaxParts()
        {
            return this.MaxParts;
        }
        public Node<Participent> GetParticipents()
        {
            return this.Participents;
        }

        public Node<Participent> IsExistPos(Participent B)
        {
            Node<Participent> pos = this.GetParticipents();
            while (pos != null)
            {
                if (pos.GetInfo().GetID() == B.GetID() && pos.GetInfo().GetName() == B.GetName())
                {
                    return pos;
                }
                pos = pos.GetNext();
            }
            return pos;


        }
        public void AddBLast(Participent B)
        {
            Node<Participent> pos = this.IsExistPos(B);
            Node<Participent> pos1 = this.GetParticipents();
            if (pos == null)
            {
                if (this.GetParticipents() == null)
                    this.Participents = new Node<Participent>(new Participent(B));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Participent>(new Participent(B)));
                }
            }

        }

        public bool CanAdd()
        {
            int cnt = 0;
            Node<Participent> pos = this.Participents;
            while (pos != null)
            {
                cnt++;
                pos = pos.GetNext();
            }
            if (cnt < this.GetMaxParts())
            {
                return true;
            }
            return false;
        }

    }
}
