// https://github.com/acenelio/encapsulamento1-csharp
using System;

namespace Ex030
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            double valor = 0.0 ;
            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
