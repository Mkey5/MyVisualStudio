//
//Problem 4. Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements
//
using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter value of a: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b: ");
            decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine(a > b ? "a > b, the greater number is: " + a : "b >= a, the greater number is: " + b);


            // with bool
            //Console.WriteLine("Enter value of a: ");
            //decimal a = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value of b: ");
            //decimal b = decimal.Parse(Console.ReadLine());

            //bool isGreater = a > b;
            //Console.WriteLine(isGreater ? "The greater number is: " + a : "The greater number is: " + b);
          
        }
    }
