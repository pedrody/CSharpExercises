// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1153/uri1153/Program.cs
using System;

namespace Ex021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
