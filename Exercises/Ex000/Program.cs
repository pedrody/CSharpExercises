// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1003/uri1003/Program.cs
using System;

namespace Ex000
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            sum = n1 + n2;

            Console.WriteLine($"SOMA = {sum}");
        }
    }
}