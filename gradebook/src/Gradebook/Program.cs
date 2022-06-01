// See https://aka.ms/new-console-template for more information
using System;
namespace Gradebook
{
    class Program
    {
       
        static void Main(string[] args)
        {

            //InMemoryBook book = new InMemoryBook("Tom's Grade Book");
            IBook book = new DiskBook("Tom's Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);
           
            var result = book.GetStatistics();
            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {result.high}");
            Console.WriteLine($"The highest grade is {result.low}");
            Console.WriteLine($"The average grade is {result.average}");
            Console.WriteLine($"The average grade is {result.letter}");
        }
        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);


                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("*******");
                }
            }
        }
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }

    
    }

    

