// https://github.com/acenelio/nivelamento-csharp/blob/master/cond01/cond01/Program.cs
using System;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}