using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_EnumerationAndStructDemo
{
    public class PieShop_UsingStruct
    {
        public static void UsingStruct()
        {
            Employee employee;
            employee.Name="Aarati";
            employee.Salary = 10000;
            employee.Work();

        }
     }
    struct Employee
    {
        public string Name;
        public int Salary;

        public void Work()
        {
            Console.WriteLine($"{Name} is now working here");
        }
    }
}
