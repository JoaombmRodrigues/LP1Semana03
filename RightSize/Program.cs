using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //verificar cada argumento dado na linha de comandos
            foreach (string s in args)
                //mostrar no ecra se comprimento for superior a 3 carateres
                //e inferior a 6 carateres
                if(s.Length > 3 & s.Length<6)
                {
                    Console.WriteLine(s);
                }
                //sair do programa se o comprimento for maior que 6 carateres
                else if(s.Length >6)
                {
                    return;
                }
        }
    }
}
