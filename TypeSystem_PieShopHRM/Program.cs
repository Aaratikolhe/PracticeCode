namespace TypeSystem_PieShopHRM
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Aarati", "Kolhe", 10000.00);
            double SalaryAfterTaxReductionEmp1 = employee1.TotalSalaryAfterTaxReduction(10000.00);
            employee1.DisplayEmployeeDetails(SalaryAfterTaxReductionEmp1);

            Employee employee2 = new Employee("Aarati", "Mahajan", 30000.00);
            double SalaryAfterTaxReductionEmp2 = employee2.TotalSalaryAfterTaxReduction(30000.00);
            employee2.DisplayEmployeeDetails(SalaryAfterTaxReductionEmp2);

            Employee.DisplayTaxRate();

            //Employee mysteryPerson = null;
            //mysteryPerson.DisplayEmployeeDetails(4000);

            Employee employee3 = new Employee("Yash", "Mahajan", null);
            double SalaryAfterTaxReductionEmp3 = employee3.TotalSalaryAfterTaxReduction(30000.00);
            employee3.DisplayEmployeeDetails(SalaryAfterTaxReductionEmp3);

            employee1 = null;
            GC.Collect();
        }
        


    }
}