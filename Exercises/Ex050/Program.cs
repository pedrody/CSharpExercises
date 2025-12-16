// https://github.com/acenelio/lambda7-csharp
using System.Globalization;
using Ex050.Entities;

namespace Ex050
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine(); // "C:\temp\in.csv"
            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(Path.GetFullPath(filePath)))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split(',');
                        string name = values[0];
                        string email = values[1];
                        double salary = double.Parse(values[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                }

                var emailsWithSalaryGreaterThan = employees
                    .Where(e => e.Salary > minSalary)
                    .OrderBy(e => e.Email)
                    .Select(e => e.Email);

                var sumOfSalariesStartingWithM = employees
                    .Where(e => e.Name[0] == 'M')
                    .Sum(e => e.Salary);

                Console.WriteLine("Email of people whose salary is more than "
                    + minSalary.ToString("F2", CultureInfo.InvariantCulture));

                foreach (string email in emailsWithSalaryGreaterThan)
                {
                    Console.WriteLine(email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': "
                    + sumOfSalariesStartingWithM.ToString("F2", CultureInfo.InvariantCulture));
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }

        }
    }
}