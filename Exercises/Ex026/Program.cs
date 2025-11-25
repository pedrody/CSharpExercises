using System;

namespace Ex026
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"AREA = {retangulo.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro():F2}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal():F2}");
        }
    }
}
