using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hishtalmoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses CS1 = new Courses();
            Participent P1 = new Participent("Participant 01", "101");
            Participent P2 = new Participent("Participant 02", "102");
            Participent P3 = new Participent("Participant 03", "103");
            Participent P4 = new Participent("Participant 04", "104");
            Participent P5 = new Participent("Participant 05", "105");
            Participent P6 = new Participent("Participant 06", "106");
            Participent P7 = new Participent("Participant 07", "107");
            Participent P8 = new Participent("Participant 08", "108");
            Participent P9 = new Participent("Participant 09", "109");
            Participent P10 = new Participent("Participant 10", "110");
            Participent P11 = new Participent("Participant 11", "111");
            Participent P12 = new Participent("Participant 12", "112");
            Participent P13 = new Participent("Participant 13", "113");
            Participent P14 = new Participent("Participant 14", "114");
            Participent P15 = new Participent("Participant 15", "115");
            Participent P16 = new Participent("Participant 16", "116");
            Participent P17 = new Participent("Participant 17", "117");

            Course C1 = new Course("777", "Zablanut", "11/5/1999", 56, 4);
            Course C2 = new Course("555", "Dog food", "11/2/2005", 23, 7);
            Course C3 = new Course("666", "Zablanut", "16/6/1666", 66, 16);

            C1.AddBLast(P1);
            C1.AddBLast(P2);
            C1.AddBLast(P3);
            C1.AddBLast(P4);

            C2.AddBLast(P17);
            C2.AddBLast(P16);
            C2.AddBLast(P15);
            C2.AddBLast(P14);
            C2.AddBLast(P13);
            C2.AddBLast(P12);
            C2.AddBLast(P11);

            C3.AddBLast(P10);
            C3.AddBLast(P9);
            C3.AddBLast(P8);
            C3.AddBLast(P7);
            C3.AddBLast(P6);
            C3.AddBLast(P5);
            C3.AddBLast(P1);
            C3.AddBLast(P13);
            C3.AddBLast(P17);
            C3.AddBLast(P2);
            C3.AddBLast(P1);

            CS1.AddBLast(C1);
            CS1.AddBLast(C2);
            CS1.AddBLast(C3);
            CS1.MoreThanOne(P1);

        }
    }
}
