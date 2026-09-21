using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Robot
    {

        private string Color = null;
        private int Slot;
        private bool inGame;

        public Robot(string Color, int Slot, bool inGame)
        {
            this.Color = Color;
            this.Slot = Slot;
            this.inGame = inGame;
        }
        public string GetColor()
        {
            return this.Color; 
        }
        public int GetSlot()
        {
            return this.Slot;
        }
        public bool GetGameStatus()
        {
            return this.inGame; 
        }
        public void SetColor(string Color1)
        {
            this.Color = Color1;
        }
        public void SetSlot(int Slot1)
        {
            this.Slot = Slot1;
        }
        public void SetGameStatus(bool inGame1)
        {
            this.inGame = inGame1;
        }
        public string RobotDescribe()
        {
            return "Color - " + this.Color + "\n" + "Slot - " + this.Slot + "\n" + "Is in game - " + this.inGame;
        }
        public void MoveForward()
        {
            this.Slot++;
        }
        public void MoveBackward()
        {
            this.Slot--;
        }
        public void JumpForward(int n)
        {
            Slot = Slot + n;
        }
        public void JumpBackward(int n)
        {
            Slot = Slot - n;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();

            Robot Bot1 = new Robot("Blue", 10, true);
            Robot Bot2 = new Robot("Black",10, true);

            int StepOption1, StepOption2;
            int i = 1;
            while (Bot1.GetSlot() != 100 && Bot2.GetSlot() != 100)
            {

                Console.WriteLine();
                Console.WriteLine("Level " + i);
                Console.WriteLine("------");

                StepOption1 = Rnd.Next(0, 4);

                switch (StepOption1)
                {
                    case 0:
                        Bot1.MoveForward();
                        break;
                    case 1:
                        Bot1.MoveBackward();
                        break;
                    case 2:
                        Bot1.JumpForward(Rnd.Next(1, 7));
                        break;
                    case 3:
                        Bot1.JumpBackward(Rnd.Next(1, 7));
                        break;
                    default:
                        break;
                }

                if (Bot1.GetSlot() == Bot2.GetSlot())
                {
                    Console.WriteLine("Bot 1 Slot - " + Bot1.GetSlot());
                    Console.WriteLine("Bot 2 Slot - " + Bot2.GetSlot());
                    Bot2.SetGameStatus(false);
                    Console.WriteLine("Robot 1 Ate Robot 2 and Won!");
                    Console.WriteLine();
                    Console.WriteLine(Bot1.RobotDescribe());
                    break;
                }

                if (Bot1.GetSlot() > 100 || Bot1.GetSlot() < 1)
                {
                    Console.WriteLine("Bot 1 Slot - " + Bot1.GetSlot());
                    Console.WriteLine("Bot 2 Slot - " + Bot2.GetSlot());
                    Bot1.SetGameStatus(false);
                    Console.WriteLine("Robot 1 is out of bounds, So Robot 2 has won!");
                    Console.WriteLine();
                    Console.WriteLine(Bot2.RobotDescribe());
                    break;
                }

                StepOption2 = Rnd.Next(0, 4);

                switch (StepOption2)
                {
                    case 0:
                        Bot2.MoveForward();
                        break;
                    case 1:
                        Bot2.MoveBackward();
                        break;
                    case 2:
                        Bot2.JumpForward(Rnd.Next(1, 7));
                        break;
                    case 3:
                        Bot2.JumpBackward(Rnd.Next(1, 7));
                        break;
                    default:
                        break;

                }

                if (Bot2.GetSlot() == Bot1.GetSlot())
                {
                    Console.WriteLine("Bot 1 Slot - " + Bot1.GetSlot());
                    Console.WriteLine("Bot 2 Slot - " + Bot2.GetSlot());
                    Bot1.SetGameStatus(false);
                    Console.WriteLine("Robot 2 Ate Robot 1 and Won!");
                    Console.WriteLine();
                    Console.WriteLine(Bot2.RobotDescribe());
                    break;
                }

                if (Bot2.GetSlot() > 100 || Bot2.GetSlot() < 1)
                {
                    Console.WriteLine("Bot 1 Slot - " + Bot1.GetSlot());
                    Console.WriteLine("Bot 2 Slot - " + Bot2.GetSlot());
                    Bot2.SetGameStatus(false);
                    Console.WriteLine("Robot 2 is out of bounds, So Robot 1 has won!");
                    Console.WriteLine();
                    Console.WriteLine(Bot1.RobotDescribe());
                    break;
                }

                Console.WriteLine("Bot 1 Slot - " + Bot1.GetSlot());
                Console.WriteLine("Bot 2 Slot - " + Bot2.GetSlot());

                ++i;
            }
           

        }
        
    }
}
