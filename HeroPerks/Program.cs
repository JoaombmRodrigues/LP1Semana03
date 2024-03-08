using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting perks
            Perks playerPerks = 0;

            //check args
            foreach(char c in args[0])
            {
                switch(c)
                {
                    case 'w':
                        playerPerks^= Perks.WaterBreathing;
                        break;
                    case 's':
                        playerPerks^= Perks.Stealth;
                        break;
                    case 'a':
                        playerPerks^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }


            //no perks
            if (playerPerks == 0)
            {
                Console.WriteLine("No Perks at all!");
            }
            //print perks
            else
            {
                Console.WriteLine(playerPerks);
            }

            //silent jumper
            if ((playerPerks & Perks.Stealth) == Perks.Stealth &&
            (playerPerks & Perks.DoubleJump)== Perks.DoubleJump)
            {
                Console.WriteLine("Silent Jumper!");
            }

            //not gonna make it
            if ((playerPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }


        }
    }
}
