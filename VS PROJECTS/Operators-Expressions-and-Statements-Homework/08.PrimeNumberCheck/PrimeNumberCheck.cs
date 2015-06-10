using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Write a positive number to check is it prime or not : ");
            int primeNum = int.Parse(Console.ReadLine());
            bool itIsPrime = true;
            if (primeNum > 1)
            {
                for (int i = 2; i < primeNum; i++)
                {
                    if (primeNum % i == 0)
                    {
                        itIsPrime = false;
                    }
                }
                Console.WriteLine("The giveb number is prime : {0}", itIsPrime);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

