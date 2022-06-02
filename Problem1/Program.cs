using System;

public class problem1
{
    public static void Main(string[] args) 
    {
        TakeChar();

        void TakeChar() 
        {
            int letter;

            Console.WriteLine("Enter Letter");
            //letter = Convert.ToChar(Console.ReadLine());
            Int32.TryParse(Console.ReadLine(), out letter);

            if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine($"The Character is Capital letter ");
            }
            if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine($"The Character is Small letter ");
            }
            if (letter >= 48 && letter <= 57)
            {
                Console.WriteLine($"The Character you entered is a number ");
            }
            //if(letter == 0 && letter <= 47 || letter >= 58 && letter <= 64 || letter >= 91 && letter <= 96 || letter >= 123 && letter <= 127)
            else
            {
                Console.WriteLine("The Character you entered is a special character ");
            }
            char choice;
            Console.WriteLine("Enter c to continue and q to exit");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'c':
                    Console.WriteLine("Your choice is to continue with code");
                    TakeChar();
                    break;

                case 'q':
                    break;

                default:
                    break;


            }

        }
    
    }

}

