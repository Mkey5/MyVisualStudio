using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number :");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter a specific bit \"p\" you whant to see :");
            int p = int.Parse(Console.ReadLine());
            uint mask = 1;
            if ((mask << p & number) == 0)
            {
                Console.WriteLine("The bit \"p\" = 0");
            }
            else
            {
                Console.WriteLine("The bit \"p\" = 1");
            }
        }
    }
