using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public abstract class Employee:IEmployee,IComparable
    {
        public int EmploeeID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public static double taxRate = 0.15;
        public int NumberOfHoursWorked{get;set;}
        public Employee()
        {
        }

        public Employee(int employeeId,string firstName, string lastName, double? salary,DateTime birthDate)
        {
            this.FirstName = firstName;
            LastName = lastName;
            BasicSalary = salary??8000;
            BirthDate = birthDate;
        }

        public double calculateTax(double salary)
        {
            return taxRate * salary;
        }

        public double TotalSalaryAfterTaxReduction()
        {
            return BasicSalary - calculateTax(BasicSalary);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First Name :{FirstName}, Last Name: {LastName}, BasicSalary: {BasicSalary},Tax Rate:{taxRate}, Total salary with tax reduction: {TotalSalaryAfterTaxReduction()}");
        }
        public static void DisplayTaxRate()
        {
            Console.WriteLine($"Tax Rate for the employees is :{taxRate}");
        }
        public abstract double ReceiveWage();
        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{ FirstName} { LastName} received bonus of Rs 3000");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"{FirstName} has done a good job");
        }

        public int CompareTo(object? obj)
        {
            var otherEmployee=(Employee)obj;
            if (EmploeeID > otherEmployee.EmploeeID)
            {
                return 1;
            }
            else if (EmploeeID < otherEmployee.EmploeeID)
                return -1;
            else
                return 0;
        }
    }
}
