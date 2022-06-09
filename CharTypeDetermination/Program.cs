namespace CharTypeDetermination
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
            char ch;
            Char.TryParse(Console.ReadLine(), out ch);
            string result=IdentifyCharType(ch);
            if (result == "Lower Case Letter")
            {
                string upperCase = result.ToUpper();
                Console.WriteLine(upperCase);
            }
            else if (result == "Upper Case Letter")
            {
                string lowerCase = result.ToLower();
                Console.WriteLine(lowerCase);
            }
            else if (result=="Digit")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result.ToUpper());
            }

        }
        public static string IdentifyCharType(char ch)
        {
            int asciiValue=(int)ch;
            if(asciiValue > 96&&asciiValue<=122)
            {
                return "Lower Case Letter";
            }
            if(asciiValue>=65&&asciiValue<=132)
            {
                return "Upper Case Letter";
            }
            if(asciiValue>=48&&asciiValue<=57)
            {
                return "Digit";
            }
            else
            {
                return "Special Character";
            }
        }
    }
}