using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter number \"a\" :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number \"b\" :");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double newA = b;
            double newB = a;
            a = newA;
            b = newB;
            Console.WriteLine(a+" "+ b);
        }
        else
        {
            Console.WriteLine(a+" "+b);
        }
    }
}
