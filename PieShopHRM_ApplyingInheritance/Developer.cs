using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public sealed class Developer : Employee
    {
        public Developer(int employeeId, string first, string last, double basicSalary, DateTime birthDate) : base(employeeId, first, last, basicSalary, birthDate)
        {

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

    //public class JuniorDeveloper:Developer
    //{
              //We cannot derive any class from sealed class
    //}
}
