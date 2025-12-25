using System;
using System.Collections.Generic;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Developer
                {
                    Name = "Fahad",
                    HourlyRate = 500,
                    HoursWorked = 160
                },
                new Manager
                {
                    Name = "Amit",
                    MonthlySalary = 80000
                }
            };

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} Salary: {emp.CalculateSalary()}");
            }

            Console.ReadLine();
        }
    }
}
