using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter positive number :");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter a specific bit \"p\" :");
            uint p = uint.Parse(Console.ReadLine());
            int mask = 1;
            bool isItOne = ((mask << (int)p & n) == 0) ? false : true;
            Console.WriteLine("The specific bit \"p\" is equal to 1 : {0}", isItOne);
        }
    }
