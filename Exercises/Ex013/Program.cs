// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1051/uri1051/Program.cs
using System;
using System.Globalization;

namespace Ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto:F2}", CultureInfo.InvariantCulture);
            }

            else if (salario <= 4500)
            {
                imposto = (1000 * 0.08) + ((salario - 3000) * 0.18);
                Console.WriteLine($"R$ {imposto:F2}", CultureInfo.InvariantCulture);
            }

            else
            {
                imposto = (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500) * 0.28);
                Console.WriteLine($"R$ {imposto:F2}", CultureInfo.InvariantCulture);
            }
        }
    }
}