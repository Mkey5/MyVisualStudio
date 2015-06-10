using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter number \"n\" to see is it prime or not : ");
        long n = long.Parse(Console.ReadLine());
        bool isIt = true;
        IsPrime(n , isIt);
    }
    static void IsPrime (long number , bool answer)
    {
        if (number > 1)
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    answer = false;
                }
            }
            Console.WriteLine("The giveb number is prime : {0}", answer);
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

            
           

