using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter the following:");
        Console.Write("Company name :");
        string companyName = Console.ReadLine();
        Console.Write("Company address :");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number :");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number :");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site :");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name :");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name :");
        string lastName = Console.ReadLine();
        Console.Write("Manager age :");
        uint age = uint.Parse(Console.ReadLine());
        Console.Write("Manager phone number :");
        string managerPNumber = Console.ReadLine();
        string noFax = "(no fax)";
        if (faxNumber == "")
        {
            faxNumber = noFax ;
        }
        else
        {
            faxNumber=faxNumber;
        }
        Console.WriteLine("");
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        Console.WriteLine("Fax: {0}",faxNumber);
        Console.WriteLine("Web site: {0}",webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,managerPNumber);
    }
}
