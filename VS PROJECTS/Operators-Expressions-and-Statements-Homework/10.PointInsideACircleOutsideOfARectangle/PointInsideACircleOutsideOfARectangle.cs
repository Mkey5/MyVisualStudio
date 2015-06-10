using System;

    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter point \"x\" : ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter point \"y\" : ");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = ((Math.Pow(x - 1, 2)) + (Math.Pow(x - 1, 2)) <= 1.5 * 1.5);
            bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
            if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("Yes , it is !");
            }
            else
            {
                Console.WriteLine("NO , it's not !");
            }
        }
    }
