using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipInfo
{
    class ZipInfo
    {
        private char ch;
        private long times;

        public ZipInfo(char ch, long times)
        {
            this.ch = ch;
            this.times = times;
        }

        public char GetCh()
        {
            return this.ch;
        }
        public long GetTimes()
        {
            return this.times;
        }

        public void SetCh(char ch)
        {
            this.ch = ch;
        }
        public void SetTimes(long Times)
        {
            this.times = Times;
        }

        public override string ToString()
        {
            return (this.GetCh() + this.GetTimes().ToString());
        }
    }
}
