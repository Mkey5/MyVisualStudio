//
//Problem 9. Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//
using System;
    class SumofNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            float sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }