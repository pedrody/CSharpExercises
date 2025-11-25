// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1134/uri1134/Program.cs
using System;

namespace Ex016
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo == 1) alcool++;
                else if (codigo == 2) gasolina++;
                else if (codigo == 3) diesel++;

                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
