using System;

    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width * 2) + (height * 2);
            Console.WriteLine(@"Perimeter = {0}",perimeter);
            double area = width * height;
            Console.WriteLine(@"Area = {0}",area);
        }
    }
