using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מינוס_1
{
    class NewHulia
    {
       private int num;
       private int digitsabove5;
       private int position;
       public NewHulia(int n, int dg5, int p)
       {
           this.num = n;
           this.digitsabove5 = dg5;
           this.position = p;
       }
       public override string ToString()
       {
           return ("Number : " + this.num + " Digits above 5 : " + this.digitsabove5 + " Place : " + this.position) + "\n";
       }
    }
}
