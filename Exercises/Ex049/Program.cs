using System.Globalization;
using Ex049.Entities;

namespace Ex049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            try
            {
                List<Product> products = new List<Product>();

                using (StreamReader sr = File.OpenText(Path.GetFullPath(filePath)))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split(',');
                        string name = values[0];
                        double price = double.Parse(values[1]);
                        products.Add(new Product(name, price));
                    }
                }

                //double avgPrice =
                //    (from p in products
                //     select p.Price).DefaultIfEmpty().Average();
                double avgPrice = products.Select(p => p.Price).DefaultIfEmpty().Average();

                //var prodNamesLessThanAvgPrice =
                //    (from p in products
                //     where p.Price < avgPrice
                //     select p.Name).OrderByDescending(p => p);
                var prodNamesLessThanAvgPrice = products
                    .Where(p => p.Price < avgPrice)
                    .OrderByDescending(p => p.Name)
                    .Select(p => p.Name);

                Console.WriteLine("Average price: " + avgPrice.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string name in prodNamesLessThanAvgPrice)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}