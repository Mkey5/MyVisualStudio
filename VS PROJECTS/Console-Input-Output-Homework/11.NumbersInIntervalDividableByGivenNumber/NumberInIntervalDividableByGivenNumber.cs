using System;

    class NumberInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number which will be the start of the interval:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a positive number which will be the end of the interval:");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                int devider = i % 5;
                if (devider == 0)
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("The existing numbers in this interval which can be divided by 5 with a remainder 0 are : {0}",sum);
        }
    }
