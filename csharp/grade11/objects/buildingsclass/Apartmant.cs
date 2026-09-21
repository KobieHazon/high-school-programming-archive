using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingsClass
{
    class Apartmant
    {
        private string OwnerN;
        private Room[] Rooms;
        private const int MaxRooms = 10;
        private int LastPos;

        public Apartmant(string OwnerN)
        {
            this.OwnerN = OwnerN;
            Rooms = new Room[MaxRooms];
            LastPos = 0;
        }

        public string GetName()
        {
            return OwnerN;
        }
        public Room[] GetRooms()
        {
            return this.Rooms;
        }
        public int GetLastPos()
        {
            return this.LastPos;
        }
        public void SetName(string OwnerN)
        {
            this.OwnerN = OwnerN;
        }
        public void SetRooms(Room[] Rooms)
        {
            this.Rooms = Rooms;
        }
        public void SetLastPos(int lastPos)
        {
            this.LastPos = lastPos;
        }

        public void Add(Room R)
        {
            if (LastPos != this.Rooms.Length)
            {
                this.Rooms[LastPos] = R;
                this.LastPos++;
            }

        }
        public void Remove(int place)
        {
            for (int i = place; i < LastPos - 1; i++)
            {
                Rooms[i] = Rooms[i + 1];
            }
            Rooms[LastPos - 1] = null;
            LastPos--;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.LastPos; i++)
            {
                s += this.Rooms[i].ToString();
            }
            return ("The Apartment Owner name - " + this.OwnerN + "\nThe number of rooms is - " + this.LastPos);
        }

        public void AprtSize(int index)
        {
            int Sum = 0;
            for (int i = 0; i < this.GetRooms().Length; i++)
            {
                Sum += this.GetRooms()[i].GetS();
            }
            Console.WriteLine(Sum);
        }


        public string AprtsCategory()
        {
            int Sum = 0;
            for (int i = 0; i < this.GetRooms().Length; i++)
            {
                Sum += this.GetRooms()[i].GetS();
            }
            if (Sum <= 70)
            {
                return "Small";
            }
            else if (Sum > 110)
            {
                return "Large";
            }
            else
            {
                return "Medium";
            }
        }

    }
}
