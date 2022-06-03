/*Write a program using a switch statement that takes one value from the user and asks about the type of conversion and 
 * then performs a conversion depending on the type of conversion.*/
class Problem3
{
    public static void Main(String[] args)
    {
        //double value;
        double cm, litre, km,kg,inch;
        int choice;
        Console.WriteLine("****Digit Convertor****");
        Console.WriteLine("1. Convert from  inches to centimetres \n2. Convert from Centimetres to inches \n3. Convert from centimetres to kilometres \n4. Convert from kilometres to centimetres  \n5. Convert from gallons to litres \n6. Convert from pounds to kilograms \n7. Quit");
        
        do
        {
            Console.WriteLine("Enter your choice for conversion");
            
            Int32.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine("Enter a number for conversion");
            double number;
            Double.TryParse(Console.ReadLine(), out number);

            switch (choice)
            {
                case 1:
                    cm = number / 2.54;
                    Console.WriteLine($"The value from inches to Centimetres = {cm}");
                    break;
                case 2:
                    inch = number * 2.54;
                    Console.WriteLine($"The value from centimetres to Inches = {inch}");
                    break;
                case 3:
                    km = number / 100000;
                    Console.WriteLine($"The value in kilometres = {km}");
                    break;
                case 4:
                    cm = number * 100000;
                    Console.WriteLine($"The value from kilometres to Centimetres = {cm}");
                    break;
                case 5:
                    litre = number * 3.785;
                    Console.WriteLine($"The value from gallons to litres = {litre}");
                    break;
                case 6:
                    kg = number * 2.20;
                    Console.WriteLine($"The value from pounds to kilogram = {kg}");
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("No choice for conversion...Ending the program");
                    break;
            }
           
        }
        while (choice != 7);
    }

    }

