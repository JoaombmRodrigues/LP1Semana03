using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for string
            Console.WriteLine("Write a string: ");
            string s = Console.ReadLine();
            //ask for a character
            Console.WriteLine("Write a character: ");
            string s2 = Console.ReadLine();
            //convert string to char
            char c = char.Parse(s2);

            foreach(char c2 in s)
                //change char to 'X'
                if(c2 == c)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(c2);
                }
            
        }
    }
}
