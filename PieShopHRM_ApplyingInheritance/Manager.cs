using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public  class Manager:Employee
    {
        
        public Manager(int employeeId,string first,string last,double basicSalary,DateTime birthDate):base(employeeId, first,last,basicSalary,birthDate)
        {

        }
        public void AttendManagementMetting()
        {
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a meeting.");
            NumberOfHoursWorked += 10;
        }
        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 5000!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 2500!");
        }

        public override double ReceiveWage()
        {
            double wage;
            if (NumberOfHoursWorked > 5)
            {
                wage =BasicSalary-( BasicSalary * taxRate)+5000;
            }
            else
                wage = BasicSalary - (BasicSalary * taxRate) + 3000;

            return wage;
        }
    }
    
}
