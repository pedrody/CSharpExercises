// https://github.com/acenelio/files1-csharp
using System.Globalization;
using Ex043.Entities;

namespace Ex043
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("File path to your CSV file: ");
            string inputFile = Path.GetFullPath(Console.ReadLine());
            string outputPath = Path.Combine(Path.GetDirectoryName(inputFile) + @"\out");
            string outputFile = Path.Combine(outputPath + @"\summary.csv");
            Directory.CreateDirectory(outputPath);

            try
            {
                using (StreamReader sr = new StreamReader(inputFile))
                {
                    using (StreamWriter sw = new StreamWriter(outputFile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(',');
                            Product item = new Product(
                                line[0], double.Parse(line[1], 
                                CultureInfo.InvariantCulture), 
                                int.Parse(line[2]));
                            sw.WriteLine(item.Name + "," + item.Total().ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}