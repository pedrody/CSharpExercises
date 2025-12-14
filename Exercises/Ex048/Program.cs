using System.Globalization;

namespace Ex048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string filePath = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(Path.GetFullPath(filePath)))
                {
                    Dictionary<string, int> dict = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int number = int.Parse(line[1]);

                        if (dict.ContainsKey(candidate))
                        {
                            dict[candidate] += number;
                        }
                        else
                        {
                            dict[candidate] = number;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in dict)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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