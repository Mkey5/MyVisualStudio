using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter a radius of a circle:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area =Math.PI*Math.Pow(radius ,2);
            Console.WriteLine("The perimeter of this circle is = {0}",Math.Round(perimeter,2));
            Console.WriteLine("The area of this circle is = {0}", Math.Round(area,2));
        }
    }
