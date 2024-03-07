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
            char c = char.Parse(s2);
        }
    }
}
