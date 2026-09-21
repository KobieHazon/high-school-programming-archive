using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingsClass
{
    class Program
    {
        public static void BiggestB(Building[] Barray)
        {
            Console.WriteLine("The building with the most large apartmants:");
            string[] OwnerA = new string[20];
            int BiggestBIndex = 0;
            int Number = 0;
            int BiggestL = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (Barray[i].GetAprts()[j].AprtsCategory() == "Large")
                    {
                        Number++;
                    }
                }
                if (Number > BiggestL)
                {
                    BiggestL = Number;
                    BiggestBIndex = i;
                    for (int j = 0; j < BiggestL; j++)
                    {
                        if (Barray[BiggestBIndex].GetAprts()[j].AprtsCategory() == "Large")
                        {
                            OwnerA[j] = Barray[BiggestBIndex].GetAprts()[j].GetName();
                        }
                    }
                }
            }
            Console.WriteLine("Name of owners:");
            for (int i = 0; i < BiggestL - 1; i++)
            {
                Console.WriteLine(OwnerA[i]);
            }
            Console.WriteLine("Address of biggest building: " + Barray[BiggestBIndex].GetAdres().ToString());

        }
        static void Main(string[] args)
        {
            Address A1 = new Address("HaNahshol", 38, "Rishon LeZion");
            Address A2 = new Address("Hara", 13, "Jerusalem");
            Address A3 = new Address("Mishgal", 69, "Mumbai");

            Room R1 = new Room("Bed Room", 5, 10);
            Room R2 = new Room("Yom Tov", 18, 2);
            Room R3 = new Room("Laila Tov", 9, 4);
            Room R4 = new Room("Charaim Tovim", 23, 6);
            Room R5 = new Room("Meshuamem Li", 14, 5);
            Room R6 = new Room("Sherutim", 2, 1);
            Room R7 = new Room("Yes", 5, 5);
            Room R8 = new Room("No", 5, 7);
            Room R9 = new Room("Black", 3, 8);
            Room R10 = new Room("White", 8, 5); 
            Room R11 = new Room("Moca", 12, 6);
            Room R12 = new Room(R4);
            int x = R2.GetS();
            Apartmant Ap1 = new Apartmant("Kobie");
            Ap1.Add(R5);
            Ap1.Add(R11);
            Room[] temp = Ap1.GetRooms();
            string s = temp[1].GetType();

            Apartmant Ap2 = new Apartmant("Motek");
            Ap2.Add(R7);
            Ap2.Add(R6);
            Building B1 = new Building(A1);
            B1.Add(Ap1);
            B1.Add(Ap2);
            Apartmant Ap3 = new Apartmant("Boxer");
            Ap3.Add(R1);
            Ap3.Add(R2);
            Ap3.Add(R3);
            Apartmant Ap4 = new Apartmant("Depeche Mode");
            Ap4.Add(R4);
            Ap4.Add(R8);
            Ap4.Add(R9);
            Building B2 = new Building(A2);
            B2.Add(Ap3);
            B2.Add(Ap4);

            Building[] Barray;
            Barray = new Building[3];
            Barray[0] = B1;
            Barray[1] = B2;


            BiggestB(Barray);

            

        }
        
    }
}
