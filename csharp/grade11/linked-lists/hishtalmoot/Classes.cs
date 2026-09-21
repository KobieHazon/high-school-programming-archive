using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hishtalmoot
{
    class Courses
    {
        private Node<Course> AllCourses;

        public Courses()
        {
            this.AllCourses = null;
        }
        public Node<Course> GetClasses()
        {
            return this.AllCourses;
        }
        public Node<Course> IsExistPos(Course B)
        {
            Node<Course> pos = this.GetClasses();
            while (pos != null)
            {
                if (pos.GetInfo().GetCode() == B.GetCode() && pos.GetInfo().GetName() == B.GetName())
                {
                    return pos;
                }
                pos = pos.GetNext();
            }
            return pos;


        }
        public void AddBLast(Course B)
        {
            Node<Course> pos = this.IsExistPos(B);
            Node<Course> pos1 = this.GetClasses();
            if (pos == null)
            {
                if (this.GetClasses() == null)
                    this.AllCourses = new Node<Course>(new Course(B));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Course>(new Course(B)));
                }
            }

        }

        public void InsertPart(Participent P, string code)
        {
            Node<Course> pos = this.AllCourses;
            while (pos.GetInfo().GetCode() != code)
                pos = pos.GetNext();

            string name = pos.GetInfo().GetName();
            if (pos.GetInfo().CanAdd() == true)
                pos.GetInfo().AddBLast(P);


            else
            {
                pos = this.AllCourses;
                while (pos != null)
                {
                    if (pos.GetInfo().GetName() == name && pos.GetInfo().CanAdd() == true)
                    {
                        Console.WriteLine("There is an available good class: \nCode- {0}.\nDate- {1}.\n", pos.GetInfo().GetCode(), pos.GetInfo().GetDate());
                    }
                    AllCourses = AllCourses.GetNext();
                }
               
            }
            pos = this.AllCourses;

        }

        public void Remove(Course C)
        {

            Node<Course> pos = IsExistPos(C);

            if (pos != null)
            {
                Node<Course> pos1 = this.GetClasses();
                if (this.AllCourses == pos)
                {
                    this.AllCourses = this.AllCourses.GetNext(); ;

                }
                else
                {
                    while (pos1.GetNext() != pos)
                    {
                        pos1 = pos1.GetNext();
                    }
                    pos1.SetNext(pos.GetNext());
                }
            }

        }

        public bool MTO(Course C, string ID)
        {
            string name = C.GetName();
            Node<Course> temp = this.GetClasses();
            this.Remove(C);
            while (temp != null)
            {
                if (temp.GetInfo().GetName() == name && temp.GetInfo().GetParticipents().GetInfo().GetID() == ID)
                {
                    return true;
                }
                temp = temp.GetNext();
            }
            return false;


        }

        public void MoreThanOne(Participent P)
        {
            Node<Course> Pos = this.AllCourses;

            bool found = false;
            while (Pos.GetNext() != null)
            {
                if (Pos.GetInfo().GetParticipents().GetInfo().GetID() == P.GetID())
                {
                    if (MTO(Pos.GetInfo(), P.GetID()) == true && found == false)
                    {
                        found = true;
                        Console.WriteLine("More than one class -" + Pos.GetInfo().GetName());
                    }
                }
                Pos = Pos.GetNext();
            }
            Pos = this.GetClasses();
            Console.WriteLine("All the classes codes: ");
            while (Pos.GetNext() != null)
            {
                if (P.GetID() == Pos.GetInfo().GetParticipents().GetInfo().GetID())
                {
                    Console.WriteLine(Pos.GetInfo().GetCode());
                }
            }
        }

    }
}
