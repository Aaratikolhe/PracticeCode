using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public  class Manager:Employee
    {
        
        public Manager(string first,string last,double basicSalary,DateTime birthDate):base(first,last,basicSalary,birthDate)
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
    }
    
}
