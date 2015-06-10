//
//Problem 3. Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 //
using System;
    class CirclePerimeterArea
    {
        static void Main()
        {

            Console.WriteLine("Type in the radius of a circle: ");
            double r = double.Parse (Console.ReadLine());

            double Perimeter = Math.PI * 2 * r;
            double Area = Math.PI * (r * r);

            Console.WriteLine("The perimeter of the circle is: {0:F2}", Perimeter);
            Console.WriteLine("The perimeter of the circle is: {0:F2}", Area);
        }
    }
