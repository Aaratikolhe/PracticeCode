
namespace Gradebook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        public const string CATEGORY="Science";

        public string Name
        {
            get 
            {
                return name; 
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
               
            }
        }
        public Book(List<double> grades, string name)
        {
            this.grades = grades;
            this.name = name;
        }
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

        public Book(string name)
        {
             grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100&&grade>=0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid value");
                Console.WriteLine("Invalisd value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            
            foreach (var grade in grades)
            {
                if (grade > result.high)
                {
                    result.high = grade;
                }
                result.low = Math.Min(result.low, grade);
                result.average += grade;
            }
            result.average /= grades.Count;
            switch (result.average)
            {
                case var a when a >= 90.0 :
                    result.letter = 'A';
                    break;

                case var a when a >= 80.0:
                    result.letter = 'B';
                    break;

                case var a when a >= 70.0:
                    result.letter = 'C';
                    break;

                case var a when a >= 60.0:
                    result.letter = 'D';
                    break;

                default:
                    result.letter = 'F';
                    break;

            }
            return result;
                    
        }

    }
}