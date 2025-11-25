// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs
using System;

namespace Ex017
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
