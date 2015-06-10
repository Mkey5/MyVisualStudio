//
//Problem 11. Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0. 
//
using System;
    class NumbersInInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 positive integers");
            int numbers = int.Parse(Console.ReadLine());
            int numbers2 = int.Parse(Console.ReadLine());
            while ((numbers < 0) || (numbers2 < 0))
            {
                Console.WriteLine("The integers need to be positive, try again!");
                numbers = int.Parse(Console.ReadLine());
                numbers2 = int.Parse(Console.ReadLine());
            }
            for (int i = numbers; i <= numbers2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

