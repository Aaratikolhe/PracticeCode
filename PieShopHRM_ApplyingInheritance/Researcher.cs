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
        public Researcher(int employeeId, string first, string last, double basicSalary, DateTime birthDate,int reserchHours) : base(employeeId, first, last, basicSalary, birthDate)
        {
            ResearchHours=reserchHours;
        }

        public void ResearchNewPieTastes()
        {
            NumberOfHoursWorked += ResearchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} is has invented a new pie taste in {ResearchHours} hours!");
        }

        public override double ReceiveWage()
        {
            double wage;
            if (NumberOfHoursWorked > 5)
            {
                wage = BasicSalary - (BasicSalary * taxRate) + 5000;
            }
            else
                wage = BasicSalary - (BasicSalary * taxRate) + 3000;

            return wage;
        }

    }

    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(int employeeId,string first, string last, double basicSalary, DateTime birthDate, int reserchHours, int hoursWorked) : base(employeeId,first, last, basicSalary, birthDate,reserchHours)
        {
        }

    }
}

    