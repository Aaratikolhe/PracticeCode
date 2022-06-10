using System;
using System.Text;

namespace TypeSystem_PieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Aarati";
            string lastName = "Kolhe";
            //string fullName = "Aarati Kolhe";
            //string noValueString = null;
            //string s;
            //s=firstName;
            //var userName = "AaratiK
            //
            string fullName=firstName+" "+lastName;
            string empIdentification=string.Concat(firstName,lastName);
            string empId=firstName.ToLower()+"_"+lastName.Trim().ToLower();
            int length=empId.Length;
            if(fullName.Contains("Aar")||fullName.Contains("aar"))
            {
                Console.WriteLine("Its Aarati");
            }
            string subString = fullName.Substring(3,2);
            Console.WriteLine("substring of characters from index 3 to 5 are " + subString);
            string replaceChar = fullName.Replace('a', 'b');
            Console.WriteLine("Full name string with a replaced by b " + replaceChar);


            string nameUsingInterpolation = $"Hello {fullName},Your employee ID is {empId}";
            Console.WriteLine(nameUsingInterpolation);

            string displayName = $"Welcome!!!! \n{firstName}\t{lastName}";
            Console.WriteLine(displayName);
            string filePath = "c:\\Newfolder\\emp.txt";
            Console.WriteLine("Path usibg Escape character"+filePath);
            string verbatimPth = @"c\NewFolder\emp.txt";
            Console.WriteLine("Path using @(verbatim path) "+verbatimPth);

            Console.WriteLine("*****String Comparison*****");
            string firstNameUpperCase = "AARATI";
            Console.WriteLine("Comparison of Aarati and AARATI: "+(firstName==firstNameUpperCase));   
            Console.WriteLine("Comparing by converting both strings to uppercase: "+(firstName.ToUpper()==firstNameUpperCase.ToUpper()));

            Console.WriteLine("*****String Immutability*****");
            string name = "Aarati";
            string anotherName = name;
            name += "Kolhe";
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Another Name: "+anotherName);
            string lowerCaseName=name.ToLower();

            StringBuilder builder=new StringBuilder();
            builder.Append("Last Name: ");
            builder.AppendLine(lastName);
            builder.Append("First Name: ");
            builder.Append(firstName);
            string result=builder.ToString();
            Console.WriteLine(result);

            Console.WriteLine("*****Parsing the string*****");
            Console.WriteLine("Enter the salary");
            string salary=Console.ReadLine();
            //int salaryInt=int.Parse(salary);
            int parsedSalary;
            if (int.TryParse(salary, out parsedSalary))
            {
                Console.WriteLine("Parsing success: " + parsedSalary);
            }
            else
                Console.WriteLine("Parsing Failure");

            string hireDate = "24/5/2020";
            DateTime hireDateTime = DateTime.Parse(hireDate);
            Console.WriteLine("Parsed Date:"+hireDateTime);

        }
    }
}