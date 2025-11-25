// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1079/uri1079/Program.cs
using System;

namespace Ex019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split();
                double v1 = double.Parse(valores[0]);
                double v2 = double.Parse(valores[1]);
                double v3 = double.Parse(valores[2]);

                double media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
