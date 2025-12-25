using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class Employee
    {
        public string Name { get; set; }

        // Abstract method (no implementation)
        public abstract double CalculateSalary();
    }

    // DERIVED CLASS 1
    public class Developer : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    // DERIVED CLASS 2
    public class Manager : Employee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    
    }

