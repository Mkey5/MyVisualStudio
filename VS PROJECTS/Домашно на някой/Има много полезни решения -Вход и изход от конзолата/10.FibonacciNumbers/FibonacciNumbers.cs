using System;
//Problem 10. Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[n];

        if (n == 1)
        {
            fibonacci[0] = 0;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, fibonacci[i]);
            }
        }
        else if (n == 2)
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, fibonacci[i]);
            }
        }
        else
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            fibonacci[2] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, fibonacci[i]);
            }
        }   
    }
}