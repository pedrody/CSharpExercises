// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1007/uri1007/Program.cs
using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            int diff = (a * b) - (c * d);
            Console.WriteLine($"DIFERENCA = {diff}");
        }
    }
}