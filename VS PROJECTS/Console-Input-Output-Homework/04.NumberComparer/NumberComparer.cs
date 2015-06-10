using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter number \"a\" :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"b\" :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater number of the two is : {0}",Math.Max(a,b));
        }
    }
