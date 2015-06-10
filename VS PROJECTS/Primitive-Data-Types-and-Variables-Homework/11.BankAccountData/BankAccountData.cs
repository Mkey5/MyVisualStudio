using System;
//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, 3 credit card numbers
//associated with the account. Declare the variables needed to keep the information 
//for a single bank account using the appropriate data types and descriptive names.
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Marek";
            string middleName = "Stanimirov";
            string lastName = "Radkov";
            decimal balance = 10053030.532m;
            string bankName = "First Investment Bank";
            string iban = "FI2585376210034721";
            string cCard1 = "1111111111111111";
            string cCard2 = "2222222222222222";
            string cCard3 = "3333333333333333";
            Console.WriteLine(@"BANK ACCOUNT

First Name - {0}
Middle Name - {1}
Last Name - {2}
Balance of the account : {3}$
Bank Name - {4}
IBAN : {5}
Credit Cards of the account:
        1. {6}
        2. {7}
        3. {8}
", firstName,middleName,lastName,balance,bankName,iban,cCard1,cCard2,cCard3);
        }
    }

