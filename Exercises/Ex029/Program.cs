using System;

namespace Ex029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = Convert.ToDouble(Console.ReadLine());
            double resultado = ConversorDeMoeda.ComprarDolar(cotacao, quantia);
            Console.WriteLine($"Valor a ser pago em reais = {resultado:F2}");
        }
    }
}
