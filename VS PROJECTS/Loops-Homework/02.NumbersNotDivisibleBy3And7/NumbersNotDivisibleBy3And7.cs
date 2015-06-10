using System;

    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Enter positive number \"n\" :");
            int n = int.Parse(Console.ReadLine());
            for (int m = 1; m <= n ; m++)
            {  
                if (m % 3 == 0 || m % 7 == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(m + " ");
                }
            }
        }
    }