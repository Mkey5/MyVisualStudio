using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Insert length side \"a\" : ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert length side \"b\" : ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert length of the height \"h\" : ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is :"+((sideA+sideB)/2)*h);
        }
    }

