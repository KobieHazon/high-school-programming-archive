using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Family
    {
        private string name;
        private int adults;
        private int teenagers;
        private int child;
        private double income;

        public Family(string name)
        {
            this.name = name;
            this.adults = 0;
            this.teenagers = 0;
            this.child = 0;
            this.income = 0;
        }

        public void Family1(int adults, int teenagers, int child, double income)
        {
            this.adults = adults;
            this.teenagers = teenagers;
            this.child = child;
            this.income = income;
        }

        public string GetName()
        {
            return this.name;
        }
        public int GetAdults()
        {
            return this.adults;
        }
        public double ZikoyFam()
        {
            double zikuy = this.adults + ((this.teenagers * 7) / 10) + ((this.child * 5) / 10);
            return zikuy;
        }
        public string Family2(double avgIncome)
        {
            if (this.income - (avgIncome * 10 / 100) > avgIncome)
            {
                return "Above AVG";
            }
            else if (this.income - (avgIncome * 10 / 100) - avgIncome > 0 && this.income - (avgIncome * 10 / 100) - avgIncome < 10 || avgIncome + (avgIncome * 10 / 100) - this.income > 0 && avgIncome + (avgIncome * 10 / 100) - this.income < 10)
                return "avarage";
            else
                return "Below avarage";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Family name:");
            Family f1 = new Family(Console.ReadLine());
            Console.WriteLine("Hey, " + f1.GetName() +" Family. How many adults are in the fam?");
            int adults = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many teenagers are in the fam?");
            int teenagers = int.Parse(Console.ReadLine());
            Console.WriteLine("Childrens?");
            int child = int.Parse(Console.ReadLine());
            Console.WriteLine("Your income?");
            double income = double.Parse(Console.ReadLine());

            f1.Family1(adults, teenagers, child, income);
            Console.WriteLine(f1.GetAdults());
            Console.WriteLine(f1.ZikoyFam());
        }
    }
}
