using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem_PieShopHRM
{
    class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private double? Salary { get; set; }

        private static double taxRate = 0.15;
        private const double bonus = 2000;
        public Employee()
        {
        }

        public Employee(string firstName, string lastName, double? salary)
        {
            this.FirstName = firstName;
            LastName = lastName;
            Salary = salary??8000;
        }

        public double calculateTax(double salary)
        {
            return taxRate * salary;
        }

        public double TotalSalaryAfterTaxReduction(double salary)
        {
            return salary - calculateTax(salary);
        }

        public void DisplayEmployeeDetails(double salaryAfterTaxReduction)
        {
            Console.WriteLine($"First Name :{FirstName}, Last Name: {LastName}, Salary: {Salary},Tax Rate:{taxRate}, Total salary with tax reduction: {TotalSalaryAfterTaxReduction(salaryAfterTaxReduction)}, Bonus amount: {bonus}");
        }
        public static void DisplayTaxRate()
        {
            Console.WriteLine($"Tax Rate for the employees is :{taxRate}");
        }
    }
}
