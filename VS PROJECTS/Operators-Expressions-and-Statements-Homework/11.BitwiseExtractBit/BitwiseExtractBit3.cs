using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number to see if the third bit is 0 or 1 :");
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;
            if ((mask << 3 & number) == 0)
            {
                Console.WriteLine("The bit #3 = 0");
            }
            else
            {
                Console.WriteLine("The bit #3 = 1");
            }
        }
    }
