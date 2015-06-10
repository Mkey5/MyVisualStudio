using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers to check which one is the biggest.");
            Console.Write("Enter number \"a\" : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"b\" : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"c\" : ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"d\" : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter number \"e\" : ");
            double e = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (c < a && d < a && e < a)
                {
                    Console.WriteLine("Number \"a\" is the biggest: {0}", a);
                }
            }
            else if (b > a)
            {
                if (c < b && d < b && e < b)
                {
                    Console.WriteLine("Number \"b\" is the biggest: {0}", b);
                }
            }
            else if (c > a)
            {
                if (b < c && d < c && e < c)
                {
                    Console.WriteLine("Number \"c\" is the biggest: {0}", c);
                }
            }
            else if (d > a)
            {
                if (b < d && c < d && e < d)
                {
                    Console.WriteLine("Number \"d\" is the biggest: {0}", d);
                }
            }
            else if (e > a)
            {
                if (b < e && c < e && d < e)
                {
                    Console.WriteLine("Number \"e\" is the biggest: {0}", e);
                }
            }
        }
    }
