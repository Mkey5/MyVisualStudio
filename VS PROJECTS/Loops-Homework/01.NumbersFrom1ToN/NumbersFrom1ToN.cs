using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number \"n\" :");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            while (m < n)
            {
                m++;
                Console.Write(m + " ");
            }
        }
    }
