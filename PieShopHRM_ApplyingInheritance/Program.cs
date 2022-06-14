namespace PieShopHRM_ApplyingInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee Aarati = new Manager(111,"Aarati","Kolhe",25000,new DateTime(06/08/1996));
            Manager Maria = new Manager(110,"Maria", "Jones", 20000, new DateTime(08 / 09 / 1994));
            Researcher Mary = new Researcher(113,"Mary", "Jones", 30000, new DateTime(07 / 09 / 1992),8);
            Developer Yash = new Developer(115,"Yash", "Charles", 40000, new DateTime(15 / 09 / 1992));

            //Employee[] employees = new Employee[5];
            //employees[0] = Aarati;
            //employees[1] = Maria;
            //employees[2] = Mary;
            //employees[3] = Yash;

            List<Employee> employees = new List<Employee>();
            employees.Add(Aarati);
            employees.Add(Maria);
            employees.Add(Mary);
            employees.Add(Yash);
            employees.Sort();

            foreach (var employee in employees)
            {
                employee.PerformWork();
                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();
                
            }


        }
    }
}