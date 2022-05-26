// See https://aka.ms/new-console-template for more information
using System;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book=new Book();
            var numbers=new []{12.7,10.3,6.11,4.1};
            List<double> grades=new List<double>(){12.7,10.3,6.11,4.1};
            grades.Add (56.1);
            // numbers[0]=12.7;
            // numbers[1]=10.2;
            // numbers[2]=10.3;

            var result = 0.0;
            // result=result+numbers[1];
            // result+=numbers[2];
            foreach (var number in grades)
            {
                result+=number;
            }
            result /=grades.Count;
            Console.WriteLine($"The average grade is {result:N5}");
            if(args.Length>0)
            {
                Console.WriteLine($"Hello, {args[0]}" );
            }
            
            else
            {

             Console.WriteLine("Hello, Aarati!");

            }
        }
    }
}

