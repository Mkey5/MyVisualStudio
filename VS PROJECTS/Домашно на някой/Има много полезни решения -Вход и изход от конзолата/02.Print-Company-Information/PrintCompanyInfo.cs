//
//Problem 2. A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.
//
using System;
class PrintCompanyInfo
{
    static void Main()
    {

        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Company phone: ");
        string companyPhone = Console.ReadLine();
        int number;
        while (!int.TryParse(companyPhone, out number))
            {
              Console.WriteLine("Invalid number, try again");
              companyPhone = Console.ReadLine();
            }
            Console.Write("Web: ");
            string companyWeb = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            int number2;
            while (!int.TryParse(companyPhone, out number2))
            {
                Console.WriteLine("Invalid number, try again");
                managerAge = Console.ReadLine();
            }
            Console.Write("Manager Phone: ");
            string managerPhone = Console.ReadLine();            
            int number3;
            while (!int.TryParse(companyPhone, out number3))
            {
                Console.WriteLine("Invalid number, try again");
                managerPhone = Console.ReadLine();
            }
                Console.WriteLine("_______________________");
                Console.WriteLine(" ");
                Console.WriteLine("Company: {0}", companyName);
                Console.WriteLine("Tel:     {0}", companyPhone);
                Console.WriteLine("Web      {0}", companyWeb);
                Console.WriteLine("Manager: {0} {1}", managerFirstName, managerLastName);
                Console.WriteLine("         {0} years old", managerAge);
                Console.WriteLine("Tel:     {0}", managerPhone);

            }
        }
