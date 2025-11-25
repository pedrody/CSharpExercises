// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1143/uri1143/Program.cs
using System;

namespace Ex023
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}
