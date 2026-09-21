using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneBook P = new PhoneBook();
            P.AddContact("Contact 01", "000-0001");
            P.AddContact("Contact 02", "000-0002");
            P.AddContact("Contact 03", "000-0003");
            P.AddContact("Contact 04", "000-0004");
            P.AddContact("Contact 05", "000-0005");
            P.AddContact("Contact 06", "000-0006");
            P.AddContact("Contact 07", "000-0007");
            P.AddContact("Contact 08", "000-0008");
            P.AddContact("Contact 09", "000-0009");
            P.AddContact("Contact 10", "000-0010");
            P.AddContact("Contact 11", "000-0011");
            P.AddContact("Contact 12", "000-0012");
            P.AddContact("Contact 13", "000-0013");
            P.AddContact("Contact 14", "000-0014");
            P.AddContact("Contact 15", "000-0015");
            P.AddContact("Contact 16", "000-0016");
            P.AddContact("Contact 17", "000-0017");


            Console.WriteLine(P.ToString());
        }
    }
}
