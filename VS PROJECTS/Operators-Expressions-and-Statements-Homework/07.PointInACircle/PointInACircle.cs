using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Insert x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y = ");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = (((x * x) + (y * y)) <= 2 * 2);
            Console.WriteLine("The point is in the circle : {0}", isInCircle);
        }
    }