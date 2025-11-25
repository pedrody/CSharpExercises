// https://github.com/acenelio/nivelamento-csharp/blob/master/cond02/cond02/Program.cs
using System;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}