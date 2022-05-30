// See https://aka.ms/new-console-template for more information
using System;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Tom's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);

            var grades=new List<double>(){12.7,10.3,6.11,4.1};
            grades.Add (56.1);

            var highGrade = double.MinValue;
            var result = 0.0;
            foreach (var number in grades)
            {
                if(number> highGrade)
                {
                    highGrade = number;
                }
                result+=number;
            }
            result /=grades.Count;
            Console.WriteLine($"The average grade is {result:N5}");
            
        }
    }
}

