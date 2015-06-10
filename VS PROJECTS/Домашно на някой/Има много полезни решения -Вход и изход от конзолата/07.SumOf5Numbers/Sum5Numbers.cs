//
//Problem 7. Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//
using System;
    class Sum5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 numbers separated by space:");
            string input = Console.ReadLine();
            string[] numbersText = input.Split();
            double[] numbers = new double[5];
            bool check = true;
            for (int i = 0; i < 5; i++)
            {
                bool checkArray = double.TryParse(numbersText[i], out numbers[i]);
                check = (check && checkArray);
            }

            double sum = 0;
            if (check == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine("The sum is: {0}", sum);
            }
            else
            {
                Console.WriteLine("invalid entry");
            }
       
	}
        }
 