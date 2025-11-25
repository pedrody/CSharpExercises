// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1114/uri1114/Program.cs
using System;

namespace Ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Senha inválida");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}