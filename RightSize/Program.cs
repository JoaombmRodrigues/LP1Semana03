using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //verificar cada argumento dado na linha de comandos
            foreach (string Str in args)
                //mostrar no ecra se comprimento for superior a 3 carateres
                if(Str.Length > 3)
                {
                    Console.WriteLine(Str);
                }
        }
    }
}
