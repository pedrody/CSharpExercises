// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1002/uri1002/Program.cs
using System;
using System.Globalization;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159D;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * raio * raio;
            Console.WriteLine($"A={area:F4}", CultureInfo.InvariantCulture);
        }
    }
}