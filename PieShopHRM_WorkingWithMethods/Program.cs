using System;
using System.Text;

namespace TypeSystem_PieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 5000;
            int months = 12;
            int bonus = 2000;

            int salaryMonth1 = 7000;
            int salaryMonth2 = 8000;
            int salaryMonth3 = 10000;

            double monthlySalary = 10000.5;
            double monthsDouble = 6.5;
            double bonusDouble = 2500.25;

            int a=20;
            int b=4;
            Console.WriteLine("Addition of two numbers using named parameters in the method: "+AddTwoNumUsinNamedParameters(a: a, b: b));

            double divison = divisonOfTwoNumbersUsingLambdaFunction(a, b);
            Console.WriteLine("Divison of two numbers using lambda function: " + divison);

            //int yearlyIncome = CalculateYearlyIncome(salary, months, bonus);
            double yearlyIncomeDouble = CalculateYearlyIncome(monthlySalary, monthsDouble, bonusDouble);
            Console.WriteLine($"The employee yearly income {yearlyIncomeDouble}");

            double AverageIncome= CalculateAverageIncomeUsingParams(salary, months, bonus);
            Console.WriteLine($"The employee average income {AverageIncome}");

            int TotalSalaryUsingOptionalParameter = CalculateIncomeWithOptionalParameters(salary, months);
            Console.WriteLine($"The employee total income {TotalSalaryUsingOptionalParameter}");

            double averageMarks=AverageMarksUsinReferenceParameters();
            Console.WriteLine($"Average marks of Rahul : {averageMarks}");

            int activityMarksUsingOut=CalculateAverageMarksUsingoutParameters();
            Console.WriteLine($"Activity marks of Rahul : {activityMarksUsingOut}");
        }
        public static int AddTwoNumUsinNamedParameters(int a,int b)
        {
            return a+b;
        }
        public static double divisonOfTwoNumbersUsingLambdaFunction(int a, int b) => a / b;
        public static int CalculateYearlyIncome(int salary, int numberOfMonthsWorked, int bonus)
        {

            if (salary < 10000)
                bonus *= 2;

            return salary * numberOfMonthsWorked + bonus;
        }

        public static double CalculateAverageIncomeUsingParams(params int[] salary)
        {
            int totalSalary = 0;
            int noOfMonth=salary.Length;

            for(int i=0; i<noOfMonth; i++)
            {
                totalSalary += salary[i]
;           }
            return totalSalary / noOfMonth;
        }

        public static double CalculateYearlyIncome(double salary, double numberOfMonthsWorked, double bonus)
        {

            if (salary < 10000)
                bonus *= 2;

            return salary * numberOfMonthsWorked + bonus;
        }
       
        public static double AverageMarksUsinReferenceParameters()
        {
            int scienceMarks = 88;
            int totalMarks = 100;
            int mathsMarks = 85;
            int englishMarks = 78;
            int activityMarks = 50;

           Console.WriteLine($"New activity marks of Rahul : {activityMarks}");

           return CalculateAverageMarksByRef(scienceMarks, englishMarks, mathsMarks, ref activityMarks);

        }
        public static int CalculateIncomeWithOptionalParameters(int salary, int numberOfMonthsWorked, int bonus=200)
        {

            if (salary < 10000)
                bonus *= 5;

            return salary * numberOfMonthsWorked + bonus;
        }
        private static double CalculateAverageMarksByRef(int scienceMarks, int englishMarks,  int mathsMarks, ref int activityMarks)
        {
            if (scienceMarks > 70)
            {
                activityMarks += 20;
            }
            return (scienceMarks + englishMarks + mathsMarks + activityMarks) / 4;
        }

        public static int CalculateAverageMarksUsingoutParameters()
        {
            int scienceMarks = 88;
            int totalMarks = 100;
            int mathsMarks = 85;
            int englishMarks = 78;
            int activityMarks;

            CalculateAverageMarksUsingOutKeyword(scienceMarks, englishMarks, mathsMarks, out activityMarks);
            //Console.WriteLine($"New activity marks of Rahul : {activityMarks}");
            return activityMarks;
        }
        private static double CalculateAverageMarksUsingOutKeyword(int scienceMarks, int englishMarks, int mathsMarks, out int activityMarks)
        {
            activityMarks = 40;
            if (scienceMarks > 70)
            {
                activityMarks += 20;
            }
            return (scienceMarks + englishMarks + mathsMarks + activityMarks) / 4;
        }

    }
}

