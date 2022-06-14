namespace PieShopHRM_ApplyingInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Aarati","Kolhe",25000,new DateTime(06/08/1996));
            Manager manager1 = new Manager("Maria", "Jones", 20000, new DateTime(08 / 09 / 1994));
            Researcher researcher1 = new Researcher("Maria", "Jones", 20000, new DateTime(08 / 09 / 1994),8);

            employee1.DisplayEmployeeDetails();
            employee1.PerformWork();
            employee1.PerformWork();
            employee1.PerformWork();
           
            manager1.DisplayEmployeeDetails();
            manager1.PerformWork();
            manager1.PerformWork();
            manager1.AttendManagementMetting();

            researcher1.ResearchNewPieTastes();
            researcher1.PerformWork();

            employee1.GiveBonus();
            manager1.GiveBonus();
            researcher1.GiveBonus();

        }
    }
}