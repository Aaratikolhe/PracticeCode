// See https://aka.ms/new-console-template for more information
using System;
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Tom's Grade Book");
            //book.AddGrade(89.1);
            //book.AddGrade(90.1);
            //book.AddGrade(87.45);
            //book.AddGrade(94.5);
            //book.AddGrade(97.88);
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input=Console.ReadLine();
                if(input=="q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("*******");
                }
            }
            book.GetStatistics();
            //List<double> grades = new List<double>();
            //grades.Add(78.55);
            //grades.Add(80.54);
            //grades.Add(92.44);
            //grades.Add(85.32);
            //grades.Add(89.45);
            //Book book2 = new Book(grades, "Ellen's Grade Book");

            var result = book.GetStatistics();
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The lowest grade is {result.high}");
            Console.WriteLine($"The highest grade is {result.low}");
            Console.WriteLine($"The average grade is {result.average}");
            Console.WriteLine($"The average grade is {result.letter}");


        }
    }
}

