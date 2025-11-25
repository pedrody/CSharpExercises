using System;

namespace Ex028
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = Convert.ToDouble(Console.ReadLine());
            aluno.N2 = Convert.ToDouble(Console.ReadLine());
            aluno.N3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal():F2}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.DiferencaAprovacao():F2} PONTOS");
            }
        }
    }
}
