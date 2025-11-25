// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1008/uri1008/Program.cs
using System;
using System.Globalization;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNum, hoursWorked;
            double hourValue, salary;

            employeeNum = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());
            hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary = hoursWorked * hourValue;
            Console.WriteLine($"NUMBER = {employeeNum}");
            Console.WriteLine($"SALARY = U$ {salary:F2}", CultureInfo.InvariantCulture);
        }
    }
}