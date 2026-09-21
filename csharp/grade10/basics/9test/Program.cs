using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Mentor
    {
        private string name;
        private string gender;
        private int rate;
        private int boyscouts;

        public Mentor(string name, string gender, int rate, int boyscouts)
        {
            this.name = name;
            this.gender = gender;
            this.rate = rate;
            this.boyscouts = boyscouts;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public void setgender(string gender)
        {
            this.gender = gender;
        }
        public void setrate(int rate)
        {
            this.rate = rate;
        }
        public void setboyscouts(int boyscouts)
        {
            this.boyscouts = boyscouts;
        }

        public string getname()
        {
            return name;
        }
        public string getgender()
        {
            return gender;
        }
        public int getrate()
        {
            return rate;
        }
        public int getboyscouts()
        {
            return boyscouts;
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many mentors are there for each age group?");
            int n = int.Parse(Console.ReadLine());
            Mentor[,] mat = new Mentor[4, n];
            string name = " "; string gender = " "; int rate = 0; int boyscouts = 0;
            int maxb = 0; int maxg = 0; int rowb = 0; int columnb = 0; int rowg = 0; int columng = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int J = 0; J < mat.GetLength(1); J++)
                {
                    Console.WriteLine("Enter mentor number {0} in age group {1}: Name, Gender, Rate, boyscouts", J+1, i+1);
                    name = Console.ReadLine();
                    gender = Console.ReadLine();
                    rate = int.Parse(Console.ReadLine());
                    boyscouts = int.Parse(Console.ReadLine());
                    mat[i, J] = new Mentor(name, gender, rate, boyscouts);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int J = 0; J < n; J++)
                {


                    if (mat[i, J].getboyscouts() >= 15)
                    {
                        if (mat[i, J].getgender() == "Male")
                        {
                            if (mat[i, J].getrate() > maxb)
                            {
                                maxb = mat[i, J].getrate();
                                rowb = i;
                                columnb = J;
                            }
                        }
                        if (mat[i, J].getgender() == "Female")
                        {
                            if (mat[i, J].getrate() > maxg)
                            {
                                maxg = mat[i, J].getrate();
                                rowg = i;
                                columng = J;
                            }
                        }
                    }
                }

                if (maxb == 0)
                {
                    Console.WriteLine("There are no suitable boy mentors");
                }
                if (maxg == 0)
                {
                    Console.WriteLine("There are no suitable girl mentors");
                }
                if (maxb != 0)
                {
                    Console.WriteLine("The best boy mentor for age group {0} is {1}.", i + 1, mat[rowb, columnb].getname());
                }
                if (maxg != 0)
                {
                    Console.WriteLine("The best girl mentor for age group {0} is {1}.", i + 1, mat[rowg, columng].getname());
                }
                rowb = 0; rowg = 0; columnb = 0; columng = 0;
                maxb = 0; maxg = 0;
            }
        }
    }
}
