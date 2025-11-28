// https://github.com/acenelio/matrix1-csharp/blob/master/Course/Program.cs
using System;

namespace Ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(row[j]);
                    if (int.Parse(row[j]) < 0) c++;
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine($"\nNegative numbers = {c}");
        }
    }
}