using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AccountInfo
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int iD = int.Parse(Console.ReadLine());
            decimal balance = decimal.Parse(Console.ReadLine());
            string active;
            if (balance >= 0)
            {
                active ="yes";
            }
            else
            {
                active = "no";
            }
            Console.WriteLine(@"Hello, {0} {1}
Client id: {2}
Total balance: {3:0.00}
Active: {4}",firstName,secondName,iD,balance,active);
        }
    }
