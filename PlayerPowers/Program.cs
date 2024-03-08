using System;
using System.Globalization;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask player number
            Console.Write("Qual o número de jogadores? ");
            string tempstr = Console.ReadLine();
            int n = int.Parse(tempstr);

            //create array
            Powers [] pwrs = new Powers[n];
            //check powers
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write($"Quais são os poderes do jogador {i+1}? ");
                    string pwrchosen = Console.ReadLine();

                    if (pwrchosen == "Fly")
                    {
                        pwrs[i]^=Powers.Fly;
                    }
                    else if (pwrchosen == "XRayVision")
                    {
                        pwrs[i]^=Powers.XRayVision;
                    }
                    else if (pwrchosen == "SuperStrength")
                    {
                        pwrs[i]^=Powers.SuperStrength;
                    }
                    else
                        continue;
                }

                //print powers
                Console.WriteLine($"Poderes do Jogador {i+1}: " + pwrs[i]);

                //flying radiation
                if ((pwrs[i] & Powers.Fly) == Powers.Fly && ((pwrs[i] & Powers.
                SuperStrength) == Powers.SuperStrength))
                {
                    Console.WriteLine("Flying radiation!");
                }
            }

        }
    }
}
