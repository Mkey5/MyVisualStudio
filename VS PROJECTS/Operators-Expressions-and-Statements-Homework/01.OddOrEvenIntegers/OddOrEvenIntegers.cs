using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool even = n % 2 == 0;
            Console.WriteLine(even);
        }
    }
