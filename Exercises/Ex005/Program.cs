// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1012/uri1012/Program.cs
using System;
using System.Globalization;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159D;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = (a * c) / 2;
            circulo = (c * c) * pi;
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"CIRCULO: {circulo:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"QUADRADO: {quadrado:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"RETANGULO: {retangulo:F3}", CultureInfo.InvariantCulture);
        }
    }
}