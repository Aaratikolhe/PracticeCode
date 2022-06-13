using PieShopHRM_EnumerationAndStructDemo;

namespace PieShopHRM_EnumerationAndStructDemo
{

    class program
    {
        public static void Main(string[] args)
        {
            int totalSalary = PieShop_UsingEnum.CalculateTotalSalaryUsingEnumeration();
            Console.WriteLine("Total salary of the Employee: " + totalSalary);
            PieShop_UsingStruct.UsingStruct();
        }
    }

}
