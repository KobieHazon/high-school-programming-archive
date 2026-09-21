using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_2014___3_
{
    class Birth
    {
        private int day;
        private int month;
        private int year;

        public Birth(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int GetDay()
        {
            return this.day;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public int GetYear()
        {
            return this.year;
        }

        public void SetDay(int day)
        {
            this.day = day;
        }
        public void SetMonth(int Month)
        {
            this.month = Month;
        }
        public void SetYear(int Year)
        {
            this.year = Year;
        }
    }
}
