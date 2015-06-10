//
//Problem 1. Write a program that reads 3 real numbers from the console and prints their sum. 
//
using System;
    class SumOf3Numbers
    {
        static void Main()
        {

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("{0} + {1} + {2} = {3} \n", num1, num2, num3, num1 + num2 + num3);

        }
    }
