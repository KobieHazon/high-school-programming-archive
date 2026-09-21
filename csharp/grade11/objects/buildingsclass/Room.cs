using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingsClass
{
    class Room
    {
        private string Type;
        private int length;
        private int width;

        public Room(string Type, int length, int width)
        {
            this.Type = Type;
            this.length = length;
            this.width = width;
        }

        public Room(Room R)
        {
            this.Type = R.GetType();
            this.length = R.GetLength();
            this.width = R.GetWidth();
        }

        public string GetType()
        {
            return this.Type;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }

        public void SetType(string Type)
        {
            this.Type = Type;
        }
        public void SetLength(int Length)
        {
            this.length = Length;
        }
        public void SetWidth(int Width)
        {
            this.width = Width;
        }

        public int GetS()
        {
            return (this.length * this.width);
        }

        public override string ToString()
        {
            return ("The Room type is - " + this.Type + "\nThe room's length and width - " + this.length + " , " + this.width);
        }
    }
}
