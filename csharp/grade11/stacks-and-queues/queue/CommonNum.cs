using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CommonNum
    {
        private int num;
        private int numoftimes;
        public CommonNum(int num, int numoftimes)
        {
            this.num = num;
            this.numoftimes = numoftimes;
        }
        public override string ToString()
        {
            return ("num :"+this.num + "Times : " +this.numoftimes + "\n");
        }
    }
}
