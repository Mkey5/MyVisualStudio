using System;
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Marek";
            string lastName = "Radkov";
            byte age = 23;
            string gender = "male";
            long iDNumber = 9101050000;
            decimal empNumber = 275600055555555527569999m;
            Console.WriteLine(@"First Name - {0}
Last Name - {1}
Age - {2}
Gender - {3}
Personal ID number - {4}
Unique employee number - {5}",firstName,lastName,age,gender,iDNumber,empNumber);


        }
    }

