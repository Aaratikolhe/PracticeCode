using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM_ApplyingInheritance
{
    public sealed class Developer : Employee
    {
        public Developer(string first, string last, double basicSalary, DateTime birthDate) : base(first, last, basicSalary, birthDate)
        {

        }
    }

    //public class JuniorDeveloper:Developer
    //{
              //We cannot derive any class from sealed class
    //}
}
