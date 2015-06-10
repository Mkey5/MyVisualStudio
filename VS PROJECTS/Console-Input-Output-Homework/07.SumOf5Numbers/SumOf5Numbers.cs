using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers separated by a space :");
            string[] numbers = Console.ReadLine().Split(' ');
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            double d = double.Parse(numbers[3]);
            double e = double.Parse(numbers[4]);
            Console.WriteLine("The sum of all five numbers is = {0}",(a+b+c+d+e));
        }
    }