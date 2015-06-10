using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers to check which one is the biggest.");
            Console.Write("Enter number \"a\" : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"b\" : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"c\" : ");
            double c = double.Parse(Console.ReadLine());

            if (a>b)
            {
                if (c<a)
                {
                    Console.WriteLine("Number \"a\" is the biggest: {0}",a);
                }
            }
            else if (b>a)
            {
                if (c<b)
                {
                    Console.WriteLine("Number \"b\" is the biggest: {0}",b);
                }
            }
            else if (c>a)
            {
                if (b<c)
                {
                    Console.WriteLine("Number \"c\" is the biggest: {0}", c);
                }
            }
        }
    }
