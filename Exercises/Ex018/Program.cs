// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs
using System;

namespace Ex018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x;
            int inside = 0;
            int outside = 0;
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            Console.WriteLine($"{inside} in");
            Console.WriteLine($"{outside} out");
        }
    }
}
