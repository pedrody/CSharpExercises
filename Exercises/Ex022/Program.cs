// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1157/uri1157/Program.cs
using System;

namespace Ex022
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
