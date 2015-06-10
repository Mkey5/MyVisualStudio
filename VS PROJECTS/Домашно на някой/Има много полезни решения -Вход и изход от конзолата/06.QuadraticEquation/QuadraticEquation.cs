//
//Problem 6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
//
using System;
using System.Text;
class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double result = (b * b) - (4 * a * c);

        Console.WriteLine("Your quadratic equation is: {0}x\u00b2+{1}x+{2} = 0", a, b, c);
        Console.WriteLine("The discriminant is {0}", result);

        if (result < 0)
        {
            Console.WriteLine("The quadratic equation have no real roots.");
        }
        else if (result == 0)
        {
            Console.WriteLine("The quadratic equation have one real root: {0}", (-b) / (2 * a));
        }
        else
        {
            Console.WriteLine("The quadratic equation have two real roots.");
            Console.WriteLine("X1 = {0}", ((-b + Math.Sqrt(result)) / (2 * a)));
            Console.WriteLine("X2 = {0}", ((-b - Math.Sqrt(result)) / (2 * a)));
        }
    }
}
