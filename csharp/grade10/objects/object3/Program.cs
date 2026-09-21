using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class OSH
        {
            public long BankID;
            public long Place;
            public long Account;
            public long ID;
            public long above;
            public long max;

            public OSH(long BankId, long Place, long Account, long ID, long above, long max)
            {
                this.BankID = BankId;
                this.Place = Place;
                this.Account = Account;
                this.ID = ID;
                this.above = above;
                this.max = max;
            }

            public void entermoney(long money, long account)
            {
                if (account == Account)
                {
                    above += money;
                }
            }

            public void takemoney(long moneyt)
            {
                if (moneyt < max)
                {
                    above = above - moneyt;
                }
            }
        }

        class KG
        {
            public string type;
            public long Account;
            public long ID;
            public int year;
            public long month;
            public long above;

            public KG(string type, long Account, long ID, int year, long month, long above)
            {
                this.type = type;
                this.Account = Account;
                this.ID = ID;
                this.year = year;
                this.month = month;
                this.above = above;
            }

            public void entermonth(long account)
            {
                if (account == Account)
                {
                    above += month;
                }
            }

            public int years(int cyear)
            {
                if ((year + 15) < cyear)
                {
                    return (cyear - year);
                }
                else
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter BankId, Place, Account, ID, above, max, type of KG, year of KG, month");
            long BankId = long.Parse(Console.ReadLine());
            long Place = long.Parse(Console.ReadLine());
            long Account = long.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            long above = long.Parse(Console.ReadLine());
            long max = long.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            long month = long.Parse(Console.ReadLine());
            OSH Op1 = new OSH(BankId, Place, Account, ID, above, max);
            KG Kp1 = new KG(type, Account, ID, year, month, above);

            Console.WriteLine("You are transfering money from OSH to KG, How much will you transfer??");
            int num = int.Parse(Console.ReadLine());

            Op1.takemoney(num);
        }
    }
}
//long BankId, long Place, long Account, long ID, long above, long max
//string type, long Account, long ID, int year, long month, long above
