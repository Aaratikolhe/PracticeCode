using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public class Researcher:Employee
    {
        public int ResearchHours { get; set; }
        public int HourlyRateofWork { get; set; }
        public double Wage { get; set; }
        public Researcher(string first, string last, double basicSalary, DateTime birthDate,int reserchHours) : base(first, last, basicSalary, birthDate)
        {
            ResearchHours=reserchHours;
        }

        public void ResearchNewPieTastes()
        {
            NumberOfHoursWorked += ResearchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} is has invented a new pie taste in {ResearchHours} hours!");
        }

        //public override double CalculateReceivedWage()
        //{
        //    double wageBeforeTax = NumberOfHoursWorked* HourlyRateofWork;
        //    double taxAmount = wageBeforeTax * taxRate;

        //    Wage = wageBeforeTax - taxAmount;

        //    Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
        //    NumberOfHoursWorked = 0;

        //    return Wage;
        //}
    }

    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, double basicSalary, DateTime birthDate, int reserchHours, int hoursWorked) : base(first, last, basicSalary, birthDate,reserchHours)
        {
        }

    }
}

    