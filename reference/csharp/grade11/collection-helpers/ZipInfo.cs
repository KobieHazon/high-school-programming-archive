using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    // פתרון לפרק רשימה שאלה 17: מחלקה המגדירה זוג - תו ומספר מופעיו 

    /// <author> צוות מדעי המחשב, המרכז להוראת המדעים, האוניברסיטה העברית, ירושלים <author/>
    /// <version> 16.12.2007 <version/>
    public class ZipInfo
    {
        private char ch;
        private long times;

        public ZipInfo(char ch, long times)
        {
            this.ch = ch;
            this.times = times;
        }

        public char GetChar()
        {
            return (this.ch);
        }

        public long GetTimes()
        {
            return (this.times);
        }

        public override string ToString()
        {
            return this.ch + ":" + this.times;
        }
    }
}
