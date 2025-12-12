using System.Globalization;
using Ex046.Entities;

namespace Ex046
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogItem> logItems = new HashSet<LogItem>();

            Console.Write("Enter file full path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader sr  = File.OpenText(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split(' ');
                        User user = new User(values[0]);
                        DateTime moment = DateTime.Parse(values[1], CultureInfo.InvariantCulture);

                        logItems.Add(new LogItem(user, moment));
                    }
                }

                Console.WriteLine("Total users: " + logItems.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}