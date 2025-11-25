// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1038/uri1038/Program.cs
using System;
using System.Globalization;

namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total;
            double preco;

            if (codigo == 1) preco = 4.00;

            else if (codigo == 2) preco = 4.50;

            else if (codigo == 3) preco = 5.00;

            else if (codigo == 4) preco = 2.00;

            else preco = 1.50;

            total = quantidade * preco;
            Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
        }
    }
}