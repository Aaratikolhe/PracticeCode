
namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject
    {
        public NamedObject()
        {

        }
        public NamedObject(string name)
        {
            Name = name;
        }


        public string Name 
        { 
            get; 
            set;
        } 
    }
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics(); 
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public  abstract class Book:NamedObject,IBook
    {
       public Book(string name):base(name)
        {

        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
       
    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))          //Using will make compiler to cleans things up when this finished with these obj or reach to the end of curly bkt of the statement
            {
                writer.WriteLine(grade);
                if(GradeAdded!=null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            Console.WriteLine("File added");

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))        
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number=double.Parse(line);
                    result.Add(number);
                    line=reader.ReadLine();
                }
            }
            return result;

        }
    }

    public class InMemoryBook : Book
    {
        private List<double> grades;
       // private string name;
        public const string CATEGORY="Science";
        public override event GradeAddedDelegate GradeAdded;

        //public string Name
        //{
        //    get 
        //    {
        //        return name; 
        //    }
        //    set
        //    {
        //        if(!String.IsNullOrEmpty(value))
        //        {
        //            name = value;
        //        }
               
        //    }
        //}
        //public InMemoryBook(List<double> grades, string name)
        //{
        //    this.grades = grades;
        //    this.name = name;
        //}
        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;

            }
        }

        public InMemoryBook(string name):base(name)
        {

             grades = new List<double>();
            Name = name;
        }
        public override void AddGrade(double grade)
        {
            if (grade <= 100&&grade>=0)
            {
                 grades.Add(grade);
                if(GradeAdded!=null)
                {
                    GradeAdded(this,new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid value");
                Console.WriteLine("Invalid value");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            
            foreach (var grade in grades)
            {
                result.Add(grade);
            }
            
            return result;

                    
        }

    }
}