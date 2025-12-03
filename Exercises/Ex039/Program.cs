using Ex039.Entities;

namespace Ex039
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product;
                switch (productType)
                {
                    case 'u':
                        Console.Write("Manufacture date (MM/DD/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        product = new UsedProduct(
                            name, price, manufactureDate
                            );
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        product = new ImportedProduct(
                                name, price, customsFee
                            );
                        break;
                    default:
                        product = new Product(name, price);
                        break;
                }
                products.Add(product);
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}