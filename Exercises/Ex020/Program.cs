// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1116/uri1116/Program.cs
using System;
using System.Globalization;

namespace Ex020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split();
                int n1 = int.Parse(valores[0]);
                int n2 = int.Parse(valores[1]);

                if (n2 != 0)
                {
                    double resultado = (double)n1 / n2;
                    Console.WriteLine(resultado.ToString("F1"), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }

            }
        }
    }
}
