namespace TypeSystem_PieShopHRM
{
    class program
    {
        public static void Main(string[] args)
        {
            int totalSalary = CalculateTotalSalaryUsingEnumeration();
            Console.WriteLine("Total salary of the Employee: "+totalSalary);
        }

        private static int CalculateTotalSalaryUsingEnumeration()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int basisSalary = 10000;
            int totalSalary = CalculateTotalSalary(basisSalary,employeeType,storeType);
            return totalSalary;
        }

        private static int CalculateTotalSalary(int basicSalary,EmployeeType employeeType,StoreType storeType)
        {
            int totalSalary = 0;
            if(employeeType== EmployeeType.Sales)
            {
                totalSalary = basicSalary * 3;
            }
            else
            {
                totalSalary=basicSalary * 2;
            }
            if(storeType==StoreType.FullPieRestaurant)
            {
                totalSalary += 1000;
            }
            return totalSalary;
        }
    }
    enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        PieCorner=10,
        Seating=20,
        FullPieRestaurant=70,
        Undefined=88

    }
}
